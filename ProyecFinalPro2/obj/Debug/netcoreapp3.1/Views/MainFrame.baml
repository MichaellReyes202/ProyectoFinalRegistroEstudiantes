   M S B A M L   `   `   `  ����J  FProyecFinalPro2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyecFinalPro2.ViewsProyecFinalPro2.Views  5   	   %    ProyecFinalPro2.Views.MainFrame   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProyecFinalPro2.Views     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2405, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $
��auto��5	   	   $
��auto��5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5   	   ��5   	   Z� .��5      � -   5         �Name$ BarraSuperior��5      
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�6#   $��2��66   $��Stretch=�6J   .��5      � .+�5       �� $	��180��6    �� Orientation$ 
Horizontal=�6)   $��40��6B   $��Right=�6N   $��1q�6j   .+�5!      �� -   5        	 ��Name$	 	ButtonMin��5!      $��Center=�60   
 � ToolTip$
 	Minimizar��6K   .��5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�62   $��20��6H   $��20��6S   $��Center=�6_   $��2q�6z   5#      �� 5$      -   5        $	 	ButtonMax��5$      $��Center=�60   $
 	Maximizar��6K   .��5%        $ WindowMaximize=�62   $��20��6H   $��20��6S   $��2q�6_   5&      �� 5'      -   5        $	 
ButtonExit��5'      $��Center=�61   $
 Cerrar��6L   .��5(        $ Close=�62   $��20��6?   $��20��6J   $��Center=�6V   $��2q�6q   5)      5*      5+      5,      � 5.   
   $��Stretch=�6   $��1��6-   $
��auto��6:      PrimaryHueMidBrush#��[  6H   .+�5/      �  50      �� 51      $��* �6$   �� 52      $��30 �6$   54      � 56      $��0��6   .+�57      �� $��Disabled=�6   $
��Auto=�6H   $��0,14,0,0q�6k   $��1��6}   .��58      �� -   5         ��Name$ MenuItem��58   !   $��10q�63   $	��515��6?   $	��Top=�6L   5:      5;      5<      � 5=      $��1��6   $��Bottom=�6    .+�5?      �� -   5        $	 Configuracion��5?      $��Center=�61   $
 Configuracion��6L   .��5@      �� $ 
Horizontal=�6!   $��Center=�6:   .+�5A      �� $��Configuracion  ��6$   
���   �6P     5B      $	 Nut=�62   $��20��6=   $��20��6H   $��3q�6T   5C      5E      5F      5H      �� 5I   
   $��1��6   $��1��6$   $��Visible=�64   .��5J      �� -   5        $ StackPanelMain��5J      $��Stretch=�62   5L      5M      5N      5O      