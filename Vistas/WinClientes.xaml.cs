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
    /// <summary>
    /// Interaction logic for WinClientes.xaml
    /// </summary>
    public partial class WinClientes : Window
    {
        public WinClientes()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            WinClientes oClientes = new WinClientes();
            oClientes.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            WinLogin menuLogin = new WinLogin();
            menuLogin.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, RoutedEventArgs e)
        {
            WinAltaCliente oAltaCLiente = new WinAltaCliente();
            oAltaCLiente.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            int buscado = int.Parse(txbBuscarDni.Text);
            Cliente oCliente = new Cliente();
            oCliente = TrabajarClientes.BuscarCliente(buscado);
            if (oCliente != null)
            {
                txtApellido.Text = oCliente.Cli_Apellido;
                txtNombre.Text = oCliente.Cli_Nombre;
                txtEmail.Text = oCliente.Cli_Email;
                txtTelefono.Text = oCliente.Cli_Telefono;
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtApellido.Text != "")
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Dni = int.Parse(txbBuscarDni.Text);
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Email = txtEmail.Text;
                oCliente.Cli_Telefono = txtTelefono.Text;
                TrabajarClientes.EditarCliente(oCliente);
                MessageBox.Show("Datos actualizados correctamente");
            }
        }
    }
}
