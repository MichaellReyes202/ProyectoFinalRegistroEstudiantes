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
using ProyecFinalPro2.Models;

namespace ProyecFinalPro2.Views
{
     public partial class LoginViews : Window, IGestionWPF
     {
          private LoginController loginController;
          private UsersModels usuarioViews;

          public LoginViews() {
               InitializeComponent();
               SeputControllers();
          }
          public void SeputControllers() {
               loginController = new LoginController(this);

               ButtonLogin.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtonExit.Click += new RoutedEventHandler(loginController.ButtonHandler);
          }

          public UsersModels GetUser() {
               usuarioViews = new UsersModels();
               usuarioViews.name = TextBlockUsuario.Text.Trim();
               usuarioViews.password = PasswordBoxUsuario.Password.Trim();
               return usuarioViews;
          }

          public void ClearUsers() {
               TextBlockUsuario.Clear();
               PasswordBoxUsuario.Clear();
          }
          public void DragMoveWindows() => this.DragMove();
     }
}
