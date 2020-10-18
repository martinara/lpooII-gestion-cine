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
    /// Interaction logic for WinAltaUsuario.xaml
    /// </summary>
    public partial class WinAltaUsuario : Window
    {
        public WinAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAbmUsuario_Click(object sender, RoutedEventArgs e)
        {
            WinAbmUsuario oAbmUsuario = new WinAbmUsuario();
            oAbmUsuario.Show();
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

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            int unRol;
            if (cbxRol.SelectedValue.ToString() == "Administrador")
            {
                unRol = 1;
            }
            else unRol = 2;

            Usuario oUsuario = new Usuario();
            oUsuario.Usu_ApellidoNombre = txtApellido.Text;
            oUsuario.Rol_Id = unRol;
            oUsuario.Usu_Username = txtUsername.Text;
            oUsuario.Usu_Password = txtPassword.Text;
            TrabajarUsuarios.AgregarUsuario(oUsuario);

            WinAbmUsuario oAbmUsuario = new WinAbmUsuario();
            oAbmUsuario.Show();
            this.Close();
        }

    }
}
