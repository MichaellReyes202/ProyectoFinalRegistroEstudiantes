using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.Views;
using ProyecFinalPro2.Interfaz;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace ProyecFinalPro2.Controller
{
     public class LoginController : IGestionController
     {
          private LoginViews loginViews;

          public LoginController(LoginViews loginViews) {
               this.loginViews = loginViews;
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
               }
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
          }
     }
}
