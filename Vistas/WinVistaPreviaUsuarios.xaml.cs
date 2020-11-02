﻿using System;
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
    /// Interaction logic for WinVistaPreviaUsuarios.xaml
    /// </summary>
    public partial class WinVistaPreviaUsuarios : Window
    {
        public WinVistaPreviaUsuarios()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pdlg = new PrintDialog();
            if (pdlg.ShowDialog() == true)
            {
                pdlg.PrintDocument(((IDocumentPaginatorSource)DocMain).DocumentPaginator, "Imprimir");
                WinListaUsuarios oListaUsuarios = new WinListaUsuarios();
                oListaUsuarios.Show();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            WinListaUsuarios oListaUsuarios = new WinListaUsuarios();
            oListaUsuarios.Show();
            this.Close();
        }
    }
}
