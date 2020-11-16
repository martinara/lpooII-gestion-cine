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
    /// Lógica de interacción para WinTrailer.xaml
    /// </summary>
    public partial class WinTrailer : Window
    {
        public WinTrailer()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            meMovie.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            meMovie.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            meMovie.Pause();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string pathMp4;
           
            
              //  pathMp4 = myMp4.FileName;
              //  lblName.Content = pathMp3;
                meMovie.LoadedBehavior = MediaState.Manual;
              //  meMovie.Source = new Uri(@"C:\Users\RENE\Documents\lpooII-TPFINAL\Vistas\videos\COCO.wmv", UriKind.Relative);
              //  meMovie.Source = new Uri(@"https://www.youtube.com/watch?v=rb0BN7CfCjU", UriKind.Absolute);
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
