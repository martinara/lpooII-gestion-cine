using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Genero
    {
        private int gen_Id;

        public int Gen_Id
        {
            get { return gen_Id; }
            set { gen_Id = value; }
        }
        private string gen_Descripcion;

        public string Gen_Descripcion
        {
            get { return gen_Descripcion; }
            set { gen_Descripcion = value; }
        }
    }
}
