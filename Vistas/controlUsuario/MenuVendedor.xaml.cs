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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas.controlUsuario
{
    /// <summary>
    /// Interaction logic for MenuVendedor.xaml
    /// </summary>
    public partial class MenuVendedor : UserControl
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            WinClientes oClientes = new WinClientes();
            oClientes.Show();
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            WinLogin menuLogin = new WinLogin();
            menuLogin.Show();
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
        }
    }
}
