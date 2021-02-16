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
          private int pElimi { get; set; }

          public UsuarioControllersAdm(UserControlUsuario user) {
               this.user = user;
               usuarioArchivos = new UsuarioArchivos();
          }

          public void ButtonHandler(object sender,RoutedEventArgs e) {
               Button button = (Button) sender;

               switch (button.Name) {
                    case "ButtonNew":
                         if (!UserExite(usuarioArchivos.Abrir(),user.GetUs())) {
                              usuarioArchivos.Guardar(user.GetUser(),true);
                              user.CargarDataGridTable(usuarioArchivos.Abrir());
                         } else {
                              MessageBox.Show("El usuario exite");
                         }
                         break;
                    case "ButtonModific":
                        
                         Modificar();
                         user.CargarDataGridTable(usuarioArchivos.Abrir());
                         break;
               }
          }

          public void e(object sender,MouseButtonEventArgs e) {
               try {
                    if (e.ChangedButton == MouseButton.Right) {
                         List<UsuariosModels> listas = usuarioArchivos.Abrir();
                         int p = user.pp();
                         listas.RemoveAt(p);
                         usuarioArchivos.Guardar(listas,false);
                         user.CargarDataGridTable(usuarioArchivos.Abrir());

                    } else if (e.ChangedButton == MouseButton.Left) {
                         MessageBox.Show("Modificar");
                         pElimi = user.GetSelectdIndex();
                         int i = 0;
                         List<UsuariosModels> listas = usuarioArchivos.Abrir();
                         foreach (var a in listas) {
                              if (pElimi == i) {
                                   user.SetText(a);
                                   break;
                              }
                              i++;
                         }
                         user.pp();
 

                    }
               } catch (Exception) {

               }
          }

          public void Modificar() {
               List<UsuariosModels> listas = usuarioArchivos.Abrir();
              
               
               try {
                    listas.RemoveAt(pElimi);
               } catch (Exception ) {
                    MessageBox.Show("errro");
               }

               try {
                    listas.Insert(pElimi,user.GetUs());
               } catch (Exception) {
                    MessageBox.Show("errro11");
               }

               try {
                    usuarioArchivos.Guardar(listas,false);
               } catch (Exception) {
                    MessageBox.Show("errro22");
               }

               
          }

          public bool UserExite(List<UsuariosModels> a,UsuariosModels b) {
               foreach (var v in a) {
                    if (v.nombre.Equals(b.nombre) || v.clave.Equals(b.clave)) {
                         return true;
                    }
               }
               return false;
          }

          public void DragMoveWindows(object sender,MouseButtonEventArgs e) {
               throw new NotImplementedException();
          }
     }
}
