﻿#pragma checksum "..\..\..\WinMenuAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA7A22255480533281721F924A3D16F16A4A307A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Vistas {
    
    
    /// <summary>
    /// WinMenuAdmin
    /// </summary>
    public partial class WinMenuAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\WinMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnUsuarios;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\WinMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnPeliculas;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\WinMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnButacas;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\WinMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnProyecciones;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\WinMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnLogout;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\WinMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vistas;component/winmenuadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WinMenuAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnUsuarios = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.btnPeliculas = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\WinMenuAdmin.xaml"
            this.btnPeliculas.Click += new System.Windows.RoutedEventHandler(this.btnPeliculas_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnButacas = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\..\WinMenuAdmin.xaml"
            this.btnButacas.Click += new System.Windows.RoutedEventHandler(this.btnButacas_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnProyecciones = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\WinMenuAdmin.xaml"
            this.btnProyecciones.Click += new System.Windows.RoutedEventHandler(this.btnProyecciones_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLogout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\WinMenuAdmin.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

