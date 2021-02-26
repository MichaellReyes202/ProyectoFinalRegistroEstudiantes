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
     class UsersViewModelController : IGestionController
     {
          private UserControlViewModel userControlView;
          private List<UsersModels> listas;
          private UsersFile usersFile;

          private int index { get; set; }

          public UsersViewModelController(UserControlViewModel userControlView) {
               this.userControlView = userControlView;
               usersFile = new UsersFile();
               listas = new List<UsersModels>();
          }

          public void ButtonHandler(object sender,RoutedEventArgs e) {
               Button button = (Button) sender;

               switch (button.Name) {
                    case "ButtonNew":
                         if (!TextBoxFull(userControlView.GetUsers())) {
                              if (!UsersExite(usersFile.Abrir(),userControlView.GetUsers())) {
                                   usersFile.Guardar(userControlView.GetUsersList(),true);
                                   UpDate();
                              } else {
                                   MessageBox.Show("El usuario existe");
                              }
                         } else {
                              MessageBox.Show("Campos vacios");
                         }
                         break;
                    case "ButtonModific":
                         if (!TextBoxFull(userControlView.GetUsers()) && index >= 0) {
                              listas.RemoveAt(index);
                              listas.Insert(index,userControlView.GetUsers());
                              usersFile.Guardar(listas,false);
                              listas.Clear();
                              UpDate();
                         } else {
                              MessageBox.Show("Campos vacios");
                         }
                         break;
               }
          }

          public void MouseClick(object sender,MouseButtonEventArgs e) {
               index = userControlView.GetDataGridTableSelectdIndex();
               listas = usersFile.Abrir();
               MessageBoxResult result = new MessageBoxResult();

               if (e.ChangedButton == MouseButton.Right) {
                    result = MessageBox.Show("Deseas Modificarlo?","Configuracion",MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes) {
                         int i = 0;
                         foreach (var a in listas) {
                              if (index == i) {
                                   userControlView.SetUsersTextBox(a);
                                   break;
                              }
                              i++;
                         }
                    }
               } else {
                    result = MessageBox.Show("Deseas Eliminarlo?","Configuracion",MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) {
                         listas.RemoveAt(index);
                         usersFile.Guardar(listas,false);
                         UpDate();
                    }
               }
          }

          public bool TextBoxFull(UsersModels users) {
               if (users.name.Equals("") || users.password.Equals("") || users.type.Equals("")) {
                    return true;
               }
               return false;
          }

          public bool UsersExite(List<UsersModels> listas,UsersModels users) {
               foreach (var v in listas) {
                    if (v.name.Equals(users.name) || v.password.Equals(users.password)) {
                         return true;
                    }
               }
               return false;
          }

          public void UpDate() {
               userControlView.LoadDataGridTable(usersFile.Abrir());
               userControlView.ClearUsersTextBox();
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
               throw new NotImplementedException();
          }
     }
}
