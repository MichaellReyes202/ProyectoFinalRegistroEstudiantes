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
using ProyecFinalPro2.Interfaz;
using ProyecFinalPro2.Controller;

namespace ProyecFinalPro2.Views
{
     public partial class LoginViews : Window, IGestionWPF
     {
          private LoginController loginController;

          public LoginViews() {
               InitializeComponent();
               SeputControllers();
               Panel2.Visibility = Visibility.Collapsed;
          }
          public void SeputControllers() {
               loginController = new LoginController(this);

               ButtonExit.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtonRegistro.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtoNewExit.Click += new RoutedEventHandler(loginController.ButtonHandler);
              
          }

          public void DragMoveWindows() => this.DragMove();

          public void Exit() => this.Close();

          public void OcultarPanel1() {
               Panel1.Visibility = Visibility.Collapsed;
               Panel2.Visibility = Visibility.Visible;
          }

          public void OcultarPanel2() {
               Panel2.Visibility = Visibility.Collapsed;
               Panel1.Visibility = Visibility.Visible;
          }
     }
}
