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
    /// Interaction logic for WinMenuAdmin.xaml
    /// </summary>
    public partial class WinMenuAdmin : Window
    {
        public WinMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            WinLogin menuLogin = new WinLogin();
            menuLogin.Show();
            this.Close();
        }

        private void btnPeliculas_Click(object sender, RoutedEventArgs e)
        {
            WinAltaPelicula oAltaPelicula = new WinAltaPelicula();
            oAltaPelicula.Show();
            this.Close();
        }
    }
}
