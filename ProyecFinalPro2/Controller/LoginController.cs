using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.Views;
using ProyecFinalPro2.Interfaz;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using ProyecFinalPro2.Archivos;

namespace ProyecFinalPro2.Controller
{
     public class LoginController : IGestionController
     {
          private LoginViews loginViews;
          private UsuarioArchivos usuarioArchivos;

          public LoginController(LoginViews loginViews) {
               this.loginViews = loginViews;
               usuarioArchivos = new UsuarioArchivos();
          }

          public void ButtonHandler(object sender,RoutedEventArgs e) {
               Button button = (Button) sender;

               switch (button.Name) {
                    case "ButtonExit":
                         loginViews.Exit();
                         break;
                    case "ButtonRegistro":
                         loginViews.OcultarPanel1();
                         break;
                    case "ButtoNewExit":
                         loginViews.OcultarPanel2();
                         break;
                    case "ButtonNewRegistro":
                         usuarioArchivos.Guardar(loginViews.NewUser(),true);
                         usuarioArchivos.a();
                         break;
               }
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
          }
     }
}
