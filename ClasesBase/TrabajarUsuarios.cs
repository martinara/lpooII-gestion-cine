using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

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
    }
}
