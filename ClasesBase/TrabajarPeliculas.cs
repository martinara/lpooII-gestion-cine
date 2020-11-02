﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace ClasesBase
{
    public class TrabajarPeliculas
    {
        //Metodo que trae una peli por defecto
        public Pelicula TraerPelicula()
        {
            Pelicula oPelicula = new Pelicula();
            oPelicula.Pel_Titulo = "";
            oPelicula.Pel_Duracion = 0;
            oPelicula.Pel_Clasificacion = "ATP";
            oPelicula.Pel_Genero = "Accion";
            return oPelicula;
        }

        // Metodo para listar las peliculas cargadas en la BD
        public ObservableCollection<Pelicula> listarPeliculas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_listar_peliculas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            ObservableCollection<Pelicula> listaPeliculas = new ObservableCollection<Pelicula>();
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pelicula oPelicula = new Pelicula();
                oPelicula.Pel_Id = (int)reader["ID"];
                oPelicula.Pel_Titulo = (string)reader["TITULO"];
                oPelicula.Pel_Duracion = (int)reader["DURACION"];
                oPelicula.Pel_Clasificacion = (string)reader["CLASIFICACION"];
                oPelicula.Pel_Genero = (string)reader["GENERO"];
                listaPeliculas.Add(oPelicula);
            }
            return listaPeliculas;
        }

        public TrabajarPeliculas()
        {

        }

        public static int AgregarPelicula(Pelicula oPelicula)
        {
            int id = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_agregar_pelicula";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@titulo", oPelicula.Pel_Titulo);
            cmd.Parameters.AddWithValue("@duracion", oPelicula.Pel_Duracion);
            cmd.Parameters.AddWithValue("@clasificacion", oPelicula.Pel_Clasificacion);
            cmd.Parameters.AddWithValue("@genero", oPelicula.Pel_Genero);
            cnn.Open();
            id = (int)cmd.ExecuteScalar();
            cnn.Close();
            return id;
        }

        public static bool EliminarPelicula(int id)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE Pelicula WHERE PEL_id = @id";
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@id", id);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static void ModificarPelicula(Pelicula oPelicula)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_editar_pelicula";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", oPelicula.Pel_Id);
            cmd.Parameters.AddWithValue("@titulo", oPelicula.Pel_Titulo);
            cmd.Parameters.AddWithValue("@duracion", oPelicula.Pel_Duracion);
            cmd.Parameters.AddWithValue("@clasificacion", oPelicula.Pel_Clasificacion);
            cmd.Parameters.AddWithValue("@genero", oPelicula.Pel_Genero);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
