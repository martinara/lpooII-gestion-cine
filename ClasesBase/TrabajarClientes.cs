using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarClientes
    {
        public TrabajarClientes()
        { }

        public Cliente TraerCliente()
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_Apellido = "";
            oCliente.Cli_Email = "";
            oCliente.Cli_Nombre = "";
            oCliente.Cli_Telefono = "";
            return oCliente;
        }

        public static Cliente BuscarCliente(int dniBuscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_buscar_cliente_dni";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pattern", dniBuscado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cliente oCliente = new Cliente();
            if (dt.Rows.Count != 0)
            {
                oCliente.Cli_Apellido = dt.Rows[0]["Apellido"].ToString();
                oCliente.Cli_Nombre = dt.Rows[0]["Nombre"].ToString();
                oCliente.Cli_Email = dt.Rows[0]["Email"].ToString();
                oCliente.Cli_Telefono = dt.Rows[0]["Telefono"].ToString();
            }
            return oCliente;
        }

        public static void EditarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.cinesConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "editar_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@email", cliente.Cli_Email);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
