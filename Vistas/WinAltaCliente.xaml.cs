using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    public partial class WinAltaCliente : Window
    {
        public WinAltaCliente()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            WinLogin menuLogin = new WinLogin();
            menuLogin.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            WinClientes oClientes = new WinClientes();
            oClientes.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea guardar los datos ingresador?", "CONFIRMACION", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Dni = int.Parse(txtDni.Text);
                oCliente.Cli_Email = txtEmail.Text;
                oCliente.Cli_Telefono = txtTelefono.Text;

                MessageBox.Show("Se guardaron los siguiente datos: \n" +
                    "\n DNI: " + oCliente.Cli_Dni.ToString() +
                    "\n NOMBRE: " + oCliente.Cli_Nombre +
                    "\n APELLIDO: " + oCliente.Cli_Apellido +
                    "\n TELEFONO: " + oCliente.Cli_Telefono +
                    "\n EMAIL: " + oCliente.Cli_Email);

                LimpiarCamposCliente();
            }
            else
            {
                LimpiarCamposCliente();
            }
        }

        private void LimpiarCamposCliente()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
    }
}
