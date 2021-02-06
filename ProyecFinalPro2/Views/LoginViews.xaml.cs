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
          private UsuarioModels usuarioViews;
          private List<UsuarioModels> listaUsuario;

          public LoginViews() {
               InitializeComponent();
               SeputControllers();
          }
          public void SeputControllers() {
               loginController = new LoginController(this);
               Panel2.Visibility = Visibility.Collapsed;

               ButtonLogin.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtonExit.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtonRegistro.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtoNewExit.Click += new RoutedEventHandler(loginController.ButtonHandler);
               ButtonNewRegistro.Click += new RoutedEventHandler(loginController.ButtonHandler);
          }

          public List<UsuarioModels> NewUser() {
               usuarioViews = new UsuarioModels();
               listaUsuario = new List<UsuarioModels>();

               usuarioViews.nombre = TextBlockNewUsuario.Text;
               usuarioViews.clave = PasswordBoxNewUsuario.Password;

               if (RadioUsuario.IsChecked == true) {
                    usuarioViews.tipoU = "Usuario";
               } else if (RadioAdminis.IsChecked == true) {
                    usuarioViews.tipoU = "Administrador";
               }

               listaUsuario.Add(usuarioViews);
               return listaUsuario;
          }

          public UsuarioModels ValidarUsuario() {
               usuarioViews = new UsuarioModels();
               usuarioViews.nombre = TextBlockUsuario.Text;
               usuarioViews.clave = PasswordBoxUsuario.Password;
               return usuarioViews;
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
