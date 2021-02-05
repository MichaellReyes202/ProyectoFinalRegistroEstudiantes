using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ProyecFinalPro2.Interfaz
{
     interface IGestionController
     {
          void ButtonHandler(object sender,RoutedEventArgs e);

          void DragMoveWindows(object sender,MouseButtonEventArgs e);
     }
}
