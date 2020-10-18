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
    /// Interaction logic for WinPeliculas.xaml
    /// </summary>
    public partial class WinPeliculas : Window
    {
        public WinPeliculas()
        {
            InitializeComponent();
        }

        private void btnPeliculas_Click(object sender, RoutedEventArgs e)
        {
            WinPeliculas oPeliculas = new WinPeliculas();
            oPeliculas.Show();
            this.Close();
        }

        private void btnButacas_Click(object sender, RoutedEventArgs e)
        {
            WinElegirButaca oElegirButaca = new WinElegirButaca();
            oElegirButaca.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            WinLogin menuLogin = new WinLogin();
            menuLogin.Show();
            this.Close();
        }

        private void btnProyecciones_Click(object sender, RoutedEventArgs e)
        {
            WinAltaProyeccion oAltaProyeccion = new WinAltaProyeccion();
            oAltaProyeccion.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            WinAltaPelicula oAltaPelicula = new WinAltaPelicula();
            oAltaPelicula.Show();
            this.Close();
        }

        private void btnAbmUsuario_Click(object sender, RoutedEventArgs e)
        {
            WinAbmUsuario oAbmUsuario = new WinAbmUsuario();
            oAbmUsuario.Show();
            this.Close();
        }
    }
}