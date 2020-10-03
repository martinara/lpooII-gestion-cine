﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarPeliculas
    {
        // Metodo para listar las peliculas cargadas en la BD
        public static DataTable listarPeliculas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_listar_peliculas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public TrabajarPeliculas()
        {

        }
    }
}