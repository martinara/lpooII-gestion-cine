using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        private int cla_Id;

        public int Cla_Id
        {
            get { return cla_Id; }
            set { cla_Id = value; }
        }
        private int gen_Id;

        public int Gen_Id
        {
            get { return gen_Id; }
            set { gen_Id = value; }
        }
        private int pel_Id;

        public int Pel_Id
        {
            get { return pel_Id; }
            set { pel_Id = value; }
        }
        private string pel_Titulo;

        public string Pel_Titulo
        {
            get { return pel_Titulo; }
            set { pel_Titulo = value; }
        }
        private int pel_Duracion;

        public int Pel_Duracion
        {
            get { return pel_Duracion; }
            set { pel_Duracion = value; }
        }
    }
}
