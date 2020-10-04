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
    }
}
