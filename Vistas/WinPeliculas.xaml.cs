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

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            WinAltaPelicula oAltaPelicula = new WinAltaPelicula();
            oAltaPelicula.Show();
            this.Close();
        }

    }
}