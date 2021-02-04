using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyecFinalPro2.Views
{
     public partial class Window1 : Window
     {
          public Window1() {
               InitializeComponent();
          }

          private void Grid_MouseDown(object sender,MouseButtonEventArgs e) {
               DragMove();
          }

          private void Button_Exit_Click(object sender,RoutedEventArgs e) {
               this.Close();
          }
     }
}
