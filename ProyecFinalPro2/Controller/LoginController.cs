using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.Views;
using ProyecFinalPro2.Interfaz;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using ProyecFinalPro2.Archivos;
using ProyecFinalPro2.Models;


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
                    case "ButtonExit": loginViews.Exit(); break;
                    case "ButtoNewExit": loginViews.OcultarPanel2(); break;
                    case "ButtonRegistro": loginViews.OcultarPanel1(); break;
                    case "ButtonNewRegistro":
                         usuarioArchivos.Guardar(loginViews.NewUser(),true);
                         loginViews.OcultarPanel2();
                         break;
                    case "ButtonLogin":
                         switch (ValidarUsuarioDatos(usuarioArchivos.Abrir(),loginViews.ValidarUsuario())) {
                              case "Usuario":
                                   MessageBox.Show("Usuario");
                                   break;
                              case "Administrador":
                                   MessageBox.Show("Admistr");
                                   break;
                              default:
                                   MessageBox.Show("No existe");
                                   break;
                         }
                         break;
               }
          }

          public string ValidarUsuarioDatos(List<UsuariosModels> l,UsuariosModels u) {
               foreach (UsuariosModels usuario in l) {
                    if (usuario.nombre.Equals(u.nombre) && usuario.clave.Equals(u.clave)) {
                         return usuario.tipoU;
                    }
               }
               return "No existe";
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
          }
     }
}
