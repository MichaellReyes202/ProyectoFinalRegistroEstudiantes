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
        private MainFrame M_Ventana;
        public MainController(MainFrame Venta)
        {
            this.M_Ventana = Venta;
        }

        public void ButtonHandler(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "ButtonMin":
                    {
                        if (M_Ventana.WindowState == WindowState.Normal)
                        {
                            M_Ventana.WindowState = WindowState.Maximized;
                        }
                        else
                        {
                            M_Ventana.WindowState = WindowState.Normal;
                        }
                    }
                    break;
                case "ButtonExit":
                    {
                        M_Ventana.Close();
                    }
                    break;
            }

        }

        public void DragMoveWindows(object sender, MouseButtonEventArgs e)
        {
            try
            {
                M_Ventana.DragMove();
            }catch(Exception) { }

        }
    }
}
