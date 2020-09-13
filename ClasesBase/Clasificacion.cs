using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Clasificacion
    {
        private int cla_Id;

        public int Cla_Id
        {
            get { return cla_Id; }
            set { cla_Id = value; }
        }
        private string cla_Descripcion;

        public string Cla_Descripcion
        {
            get { return cla_Descripcion; }
            set { cla_Descripcion = value; }
        }
    }
}
