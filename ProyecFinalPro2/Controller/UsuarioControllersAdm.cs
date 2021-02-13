using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.ViewModel;
using ProyecFinalPro2.Interfaz;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using ProyecFinalPro2.Archivos;

namespace ProyecFinalPro2.Controller
{
     class UsuarioControllersAdm : IGestionController
     {
          private UserControlUsuario user;
          private UsuarioArchivos usuarioArchivos;

          public UsuarioControllersAdm (UserControlUsuario user) {
               this.user = user;
               usuarioArchivos = new UsuarioArchivos();
          }

          public void ButtonHandler(object sender,RoutedEventArgs e) {
               Button button = (Button) sender;

               switch (button.Name) {
                    case "ButtonNew":
                        usuarioArchivos.Guardar(user.GetUser(),true);
                         user.CargarDataGridTable(usuarioArchivos.Abrir());
                         break;
               }
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
               throw new NotImplementedException();
          }
     }
}
