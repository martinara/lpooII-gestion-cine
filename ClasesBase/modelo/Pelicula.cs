using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        private string pel_Clasificacion;

        public string Pel_Clasificacion
        {
            get { return pel_Clasificacion; }
            set { pel_Clasificacion = value; }
        }

        private string pel_Genero;

        public string Pel_Genero
        {
            get { return pel_Genero; }
            set { pel_Genero = value; }
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
        private string pel_Imagen;

        public string Pel_Imagen
        {
            get { return pel_Imagen; }
            set { pel_Imagen = value; }
        }

        private string pel_Avance;

        public string Pel_Avance
        {
            get { return pel_Avance; }
            set { pel_Avance = value; }
        }
    }
}
