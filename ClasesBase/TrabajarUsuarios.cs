using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
