using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace ClasesBase
{
    public class TrabajarUsuarios
    {
        public Usuario TraerUsuario()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Usu_Username = "";
            oUsuario.Usu_Password = "";
            return oUsuario;
        }

        public TrabajarUsuarios()
        {
        }

        public ObservableCollection<Usuario> TraerUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            ObservableCollection<Usuario> listaUsuarios = new ObservableCollection<Usuario>();
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Usu_Id = (int)reader["USU_id"];
                oUsuario.Usu_ApellidoNombre = (string)reader["USU_apellidoNombre"];
                oUsuario.Usu_Username = (string)reader["USU_username"];
                oUsuario.Usu_Password = (string)reader["USU_password"];
                oUsuario.Rol_Id = (int)reader["ROL_id"];
                listaUsuarios.Add(oUsuario);
            }
            return listaUsuarios;
        }
    }
}
