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
using System.Collections.ObjectModel;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for WinListaUsuarios.xaml
    /// </summary>
    public partial class WinListaUsuarios : Window
    {
        private CollectionViewSource vistaColeccionFiltrada;

        public WinListaUsuarios()
        {
            InitializeComponent();
            vistaColeccionFiltrada = Resources["VISTA_USER"] as CollectionViewSource;
        }

        

        private void eventVistaUsuario_Filter(object sender, FilterEventArgs e)
        {
            Usuario oUsuario = e.Item as Usuario;
            if (oUsuario.Usu_Username.StartsWith(txtFiltrarUsername.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        private void btnAbmUsuarios_Click(object sender, RoutedEventArgs e)
        {
            WinAbmUsuario oAbmUsuario = new WinAbmUsuario();
            oAbmUsuario.Show();
            this.Close();
        }

        private void btnListaUsuarios_Click(object sender, RoutedEventArgs e)
        {
            WinListaUsuarios oListaUsuarios = new WinListaUsuarios();
            oListaUsuarios.Show();
            this.Close();
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

        private void btnProyecciones_Click(object sender, RoutedEventArgs e)
        {
            WinAltaProyeccion oAltaProyeccion = new WinAltaProyeccion();
            oAltaProyeccion.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            WinLogin menuLogin = new WinLogin();
            menuLogin.Show();
            this.Close();
        }

        private void txtFiltrarUsername_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (vistaColeccionFiltrada != null)
            {
                vistaColeccionFiltrada.Filter += eventVistaUsuario_Filter;
            }
        }
    }
}
