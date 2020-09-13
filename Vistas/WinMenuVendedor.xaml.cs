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

namespace Vistas
{
    /// <summary>
    /// Interaction logic for WinMenuVendedor.xaml
    /// </summary>
    public partial class WinMenuVendedor : Window
    {
        public WinMenuVendedor()
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
            WinAltaCliente oAltaCliente = new WinAltaCliente();
            oAltaCliente.Show();
            this.Close();
        }
    }
}
