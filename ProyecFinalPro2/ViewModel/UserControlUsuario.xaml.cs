using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ProyecFinalPro2.Archivos;
using ProyecFinalPro2.Models;
using ProyecFinalPro2.Controller;
using ProyecFinalPro2.Interfaz;

namespace ProyecFinalPro2.ViewModel
{
     public partial class UserControlUsuario : UserControl, IGestionWPF
     {
          private UsuarioArchivos usuarioArchivos;
          private UsuarioControllersAdm usuarioControllersAdm;
          private UsuariosModels usuariosModels;

          public UserControlUsuario() {
               InitializeComponent();
               SeputControllers();
               LoadDataGridTable(usuarioArchivos.Abrir());
          }

          public void SeputControllers() {
               usuarioControllersAdm = new UsuarioControllersAdm(this);
               usuarioArchivos = new UsuarioArchivos();
               usuariosModels = new UsuariosModels();

               ButtonNew.Click += new RoutedEventHandler(usuarioControllersAdm.ButtonHandler);
               DataGridTable.MouseDown += new MouseButtonEventHandler(usuarioControllersAdm.e);
               ButtonModific.Click += new RoutedEventHandler(usuarioControllersAdm.ButtonHandler);
          }

          public UsuariosModels GetUsers() {
               usuariosModels.nombre = TextBoxName.Text.Replace(" ","").Trim();
               usuariosModels.clave = TextBoxPassword.Text.Replace(" ","").Trim();
               usuariosModels.tipoU = TextBoxUserType.Text.Replace(" ","").Trim();
               return usuariosModels;
          }

          public List<UsuariosModels> GetUsersList(UsuariosModels usuariosModels) {
               List<UsuariosModels> listas = new List<UsuariosModels>();
               listas.Add(usuariosModels);
               return listas;
          }

          public void LoadDataGridTable(List<UsuariosModels> listas) {
               DataGridTable.Items.Clear();
               foreach (var v in listas) {
                    DataGridTable.Items.Add(v);
               }
          }

          public void SetUsersTextBox(UsuariosModels usuariosModels) {
               TextBoxName.Text = usuariosModels.nombre;
               TextBoxPassword.Text = usuariosModels.clave;
               TextBoxUserType.Text = usuariosModels.tipoU;
          }

          public void ClearUsersTextBox() {
               TextBoxName.Clear();
               TextBoxPassword.Clear();
               TextBoxUserType.Clear();
          }

          public bool TextBoxUserFull(UsuariosModels users) {
               if (users.nombre.Equals("") || users.clave.Equals("") || users.tipoU.Equals("")) {
                    return true;
               }
               return false;
          }

          public int RemoveAtDataGridTable() {
               int index = GetDataGridTableSelectdIndex();
               DataGridTable.Items.RemoveAt(index);
               return index;
          }

          public int GetDataGridTableSelectdIndex() {
               return DataGridTable.SelectedIndex;
          }
     }
}