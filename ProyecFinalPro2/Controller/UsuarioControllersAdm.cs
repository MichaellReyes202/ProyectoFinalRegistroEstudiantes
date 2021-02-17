using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.ViewModel;
using ProyecFinalPro2.Interfaz;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using ProyecFinalPro2.Archivos;
using ProyecFinalPro2.Models;

namespace ProyecFinalPro2.Controller
{
     class UsuarioControllersAdm : IGestionController
     {

          private UserControlUsuario user;
          private UsuarioArchivos usuarioArchivos;
          private List<UsuariosModels> listas;

          private int index { get; set; }
          private int i { get; set; }

          public UsuarioControllersAdm(UserControlUsuario user) {
               this.user = user;
               usuarioArchivos = new UsuarioArchivos();
               listas = new List<UsuariosModels>();
          }

          public void ButtonHandler(object sender,RoutedEventArgs e) {
               Button button = (Button) sender;

               switch (button.Name) {
                    case "ButtonNew":
                         if (!user.TextBoxUserFull(user.GetUsers())) {
                              if (!UsersExite(usuarioArchivos.Abrir(),user.GetUsers())) {
                                   usuarioArchivos.Guardar(user.GetUsersList(user.GetUsers()),true);
                                   user.LoadDataGridTable(usuarioArchivos.Abrir());
                                   user.ClearUsersTextBox();
                              } else {
                                   MessageBox.Show("El usuario exite");
                              }
                         } else {
                              MessageBox.Show("Campos basios");
                         }
                         break;
                    case "ButtonModific":
                         if (!user.TextBoxUserFull(user.GetUsers()) && index >= 0) {
                              UserModify();
                              user.LoadDataGridTable(usuarioArchivos.Abrir());
                              user.ClearUsersTextBox();
                         } else {
                              MessageBox.Show("Campos basios");
                         }

                         break;
               }
          }

          public void e(object sender,MouseButtonEventArgs e) {
               index = user.GetDataGridTableSelectdIndex();
               listas = usuarioArchivos.Abrir();

               try {
                    if (e.ChangedButton == MouseButton.Right) {
                         MessageBox.Show("eliminaar");
                         listas.RemoveAt(index);
                         usuarioArchivos.Guardar(listas,false);
                         user.LoadDataGridTable(usuarioArchivos.Abrir());
                         user.ClearUsersTextBox();
                         listas.Clear();
                    } else if (e.ChangedButton == MouseButton.Left) {
                         MessageBox.Show("Modificar");
                         int i = 0;
                         foreach (var a in listas) {
                              if (index == i) {
                                   user.SetUsersTextBox(a);
                                   break;
                              }
                              i++;
                         }
                    }
               } catch (Exception) {

               }
          }

          public bool UsersExite(List<UsuariosModels> listas,UsuariosModels users) {
               foreach (var v in listas) {
                    if (v.nombre.Equals(users.nombre) || v.clave.Equals(users.clave)) {
                         return true;
                    }
               }
               return false;
          }

          public void UserModify() {
               listas.RemoveAt(index);
               listas.Insert(index,user.GetUsers());
               usuarioArchivos.Guardar(listas,false);
               listas.Clear();
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
               throw new NotImplementedException();
          }
     }
}
