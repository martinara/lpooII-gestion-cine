using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
   public class TrabajarCliente
    {
        public Cliente TraerCliente() {

            Cliente oCliente = new Cliente();
            oCliente.Cli_Nombre = "";
            oCliente.Cli_Apellido = "";
            oCliente.Cli_Dni=0;
            oCliente.Cli_Telefono = 0;

            return oCliente;
        
        }
        public TrabajarCliente() { }

    }
}
