   M S B A M L   `   `   `  ����
  Vistas    Vistas.WinAltaProyeccion   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Cinemax - Administrador��5   	   $	��600��6)   $	��900��66    � 
ResizeMode$ NoResize=�6B    � Icon$- '/Vistas;component/images/icono-cine.ico��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ��5
   
   �� 5       �� ImageSource$% /Vistas;component/images/bg.jpg��6   .+�5   
   �� $��
20,0,20,20q�6   .+�5      � $��70��6    � ColumnDefinitions 5      �� 5      $	��100 �6'   �� 5      $	��600 �6'   .+�5      �� $��0��6   $,��&/Vistas;component/images/logo-menu.png��6(   o� 5      $��1��6   
�������
������ $��10,20,10,20q�6S   $��Center=�6h   $��Center=�6�   .@�5      m� -   5        $��btnUsuarios��5   1   $��Usuarios��6   $��20(�6D   m� 5      -   5        $��btnPeliculas��5   2   $��	Peliculas��6   $��20(�6F   6T   m� 5      -   5        $��
btnButacas��5   0   $��Butacas��6   $��20(�6B   6P   m� 5      -   5        $��btnProyecciones��5   5   $��Proyecciones��6   $��20(�6L   6Z   m� 5      -   5        $��	btnLogout��5   6   $��Cerrar Sesion��6   $��20(�6G   6U   5      5!      �� 5#      6   �� 5%      $��300,20,300,20q�6   .+�5&      �� -   5        $��	lblTitulo��5&      $��ALTA DE PROYECCION��6)   
�������$��20(�6Y   $��Center=�6g   �� 5'      6   �� 5(      -   5        $��lblPelicula��5(      $��Pelicula��6+   
�������$��0,10,0,0q�6Q   �� 5)      -   5        $��txtPelicula��5)      $��0,0,0,0q�6-      	EstiloTxb#��[  6>   �� 5*      -	   5        $��lblFecha��5*      $��Fecha��6(   
�������$��0,10,0,0q�6K   (  "System.Windows.Controls.DatePicker  5+      -
   5        $��dtFecha��5+      6.   �� 5,      -   5        $��
lblHorario��5,      $��Horario��6*   
�������$��0,10,0,0q�6O   �� 5-      -   5        $��
txtHorario��5-      $��0,0,0,0q�6,   #��[  6=   �� 5.      -   5        $��lblSala��5.      $
��Sala��6'   
�������$��0,10,0,0q�6I   �� 5/      -   5        $��txtSala��5/      $��0,0,0,0q�6)   #��[  6:   �� 50      -   5        $��lblError��50      
���  ��$��0,10,0,0q�69   �� 51      -   5        $��btnRegistrar��51      $��	Registrar��6-   $��
60,10,60,0q�6A     PlantillaBtn#��[ 6p   52      54      56      58      