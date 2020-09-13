using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        private int usu_Id;

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        private string usu_Password;

        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }
        private string usu_Username;

        public string Usu_Username
        {
            get { return usu_Username; }
            set { usu_Username = value; }
        }
    }
}
