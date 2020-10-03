﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Usuario : IDataErrorInfo
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

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string msg_error = null;
                switch (columnName)
                {
                    case "Usu_Username":
                        msg_error = validar_Username();
                        break;
                    case "Usu_Password":
                        msg_error = validar_Password();
                        break;
                }
                return msg_error;
            }
        }

        private string validar_Username()
        {
            if (String.IsNullOrEmpty(Usu_Username))
            {
                return "El valor del campo es obligatorio";
            }
            return null;
        }

        private string validar_Password()
        {
            if (String.IsNullOrEmpty(Usu_Password))
            {
                return "El valor del campo es obligatorio";
            }
            else if (Usu_Password.Length < 5)
            {
                return "Debe tener al menos 5 caracteres";
            }
            return null;
        }
    }
}