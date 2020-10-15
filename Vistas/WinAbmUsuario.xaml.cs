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
    /// Interaction logic for WinAbmUsuario.xaml
    /// </summary>
    public partial class WinAbmUsuario : Window
    {
        public WinAbmUsuario()
        {
            InitializeComponent();
        }

        private void btnAbmUsuarios_Click(object sender, RoutedEventArgs e)
        {
            WinAbmUsuario oAbmUsuario = new WinAbmUsuario();
            oAbmUsuario.Show();
            this.Close();
        }

        CollectionView Vista;
        ObservableCollection<Usuario> listaUsuarios;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_USER"];
            listaUsuarios = odp.Data as ObservableCollection<Usuario>;
            Vista = (CollectionView)CollectionViewSource.GetDefaultView(stack_content.DataContext);
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

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToPrevious();
            if (Vista.IsCurrentBeforeFirst)
            {
                Vista.MoveCurrentToLast();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToNext();
            if (Vista.IsCurrentAfterLast)
            {
                Vista.MoveCurrentToFirst();
            }
        }
    }
}
