using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.Views;
using System.Windows;
using System.Windows.Controls;
using ProyecFinalPro2.Interfaz;
using System.Windows.Input;

namespace ProyecFinalPro2.Controller
{
    class MainController : IGestionController
    {
        private MainFrame M_Ventan;
        public MainController(MainFrame Venta)
        {
            this.M_Ventan = Venta;
        }

        public void ButtonHandler(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "ButtonMin":
                    {
                        if (M_Ventan.WindowState == WindowState.Normal)
                        {
                            M_Ventan.WindowState = WindowState.Maximized;
                        }
                        else
                        {
                            M_Ventan.WindowState = WindowState.Normal;
                        }
                    }
                    break;
                case "ButtonExit":
                    {
                        M_Ventan.Close();
                    }
                    break;
            }

        }

        public void DragMoveWindows(object sender, MouseButtonEventArgs e)
        {

<<<<<<< HEAD
=======
            try
            {
                M_Ventan.DragMove();
            }catch(Exception ex) { }
>>>>>>> f89e0bec2bb7f6fde5668fd5fef17ba58a21da09
               try {
                    M_Ventan.DragMove();
               } catch (Exception) {

               }
             
<<<<<<< HEAD

=======
>>>>>>> f89e0bec2bb7f6fde5668fd5fef17ba58a21da09
        }
    }
}
