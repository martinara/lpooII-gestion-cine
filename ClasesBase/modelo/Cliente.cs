﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        private int cli_Dni;

        public int Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        private string cli_Email;

        public string Cli_Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }
        private int cli_Id;

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private int cli_Telefono;

        public int Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }
    }
}
