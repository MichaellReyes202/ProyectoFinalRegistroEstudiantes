   M S B A M L   `   `   `  ����J  FProyecFinalPro2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyecFinalPro2.ViewsProyecFinalPro2.Views  5   	   &     ProyecFinalPro2.Views.LoginViews   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProyecFinalPro2.Views     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2405, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�62    � WindowStyle$
 None=�6W    � 
ResizeMode$ NoResize=�6j   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,0&�65   .��5      �  � Color$ 	#FF1F3D68��6    � Offset$ 1Q�61   � 5      $ 	#FF2196F3��6   $ 0Q�61   5      .+�5   
   �� $	��390��6   $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   
�������5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��Resources/imagen1.bmp��6   $	��300��67   $	��300��6C   $	��Top=�6P   $��30q�6h   $
��Fill=�6t   5      �� 5"      $	��350��6   .+�5#      �� -   5        
 ��Name$
 Panel1��5#      $��20 40q�6-   .+�5$      �� $��Usuario Login��6    $��20q�65   ���	#FF1368BD �� TextAlignment$ Center=�6X   $��28(�6o   $
��Bold"�6}   $��Segoe UI)�6�   �� 5%      $	 
Horizontal=�6!   $��10q�6:   .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   ���	#FF1368BD6U   �� 5'      -   5         ��Name$ TextBlockUsuario��5'   "   $
��10 0q�6<   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��6J   
���   �$	��250��6�   $��16(�6�   $��Segoe UI)�6�    � Cursor$ IBeam��6�   ���	#FF1368BD �� SelectionBrush
 �����6�   5(      �� 5)      $	 
Horizontal=�6!   $��10q�6:   .+�5*        $
 Lock=�62   $��25��6>   $��25��6I   ���	#FF1368BD6U   G� 5+      -   5         G�Name$ PasswordBoxUsuario��5+   &   $
��10 0q�6B   $ Contraseña��6P   
���   �$	��250��6�   $��16(�6�   $��Segoe UI)�6�   $ IBeam��6�   $��Normal"�6�   ���	#FF1368BD G� SelectionBrush
 �����6�   5,      �� 5-      $��10q�6!   $��Center=�6-   .+�5.      �� -   5         ��Name$ ButtonLogin��5.   !   $	��130��66   $��40��6B   ���	#FF1368BD   MaterialDesignRaisedButton#��[  6f   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��6�   $��0q�6�   
�������$��Entrar��6�   $��Segoe UI)�6   $��23(�6  5/      50      52      56      �� 57      $
�� 100��6   .+�58      �� -   5        $ 
ButtonExit��58      $��10 20q�6-    , (MaterialDesignFloatingActionAccentButton#��[ 6<   ���	#FF1368BD���	#FF1368BD$��Segoe UI)�6�   .��59        $ Close=�6.   
�������$��30��6N   $��30��6Y   5:      5;      5?      5@      5A      