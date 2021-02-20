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
          private UsersFile usersFile;
          private MainFrame mainFrame1;

          public LoginController(MainFrame mainFrame1) {
               this.mainFrame1 = mainFrame1;
          }

          public LoginController(LoginViews loginViews) {
               this.loginViews = loginViews;
               usersFile = new UsersFile();
          }

          public void ButtonHandler(object sender,RoutedEventArgs e) {
               Button button = (Button) sender;

               switch (button.Name) {
                    case "ButtonExit":
                         this.loginViews.Close();
                         break;
                    case "ButtonLogin":
                         if (!TextBoxFull(loginViews.GetUser())) {
                              string type = ValidateData(usersFile.Abrir(),loginViews.GetUser());

                              switch (type) {
                                   case "Usuario":
                                        ShowMainFrame(false);
                                        break;
                                   case "Administrador":
                                        ShowMainFrame(true);
                                        break;
                                   default:
                                        MessageBox.Show("El Usuario no existe","Login");
                                        break;
                              }
                         } else {
                              MessageBox.Show("Completar Registro","Login");
                         }
                         break;
               }
               loginViews.ClearUsers();
          }

          private string ValidateData(List<UsersModels> l,UsersModels u) {
               foreach (UsersModels usuario in l) {
                    if (usuario.name.Equals(u.name) && usuario.password.Equals(u.password)) {
                         return usuario.type;
                    }
               }
               return "No existe";
          }

          public bool TextBoxFull(UsersModels users) {
               if (users.name.Equals("") || users.password.Equals("")) {
                    return true;
               }
               return false;
          }

          private void ShowMainFrame(bool v) {
               this.loginViews.Hide();
               MainFrame mainFrame = new MainFrame(v);
               mainFrame.ShowDialog();
               this.loginViews.Close();
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
          }
     }
}
