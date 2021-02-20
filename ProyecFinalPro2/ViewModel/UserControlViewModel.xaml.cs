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
     public partial class UserControlViewModel : UserControl, IGestionWPF
     {
          private UsersFile usersFile;
          private UsersViewModelController usersViewModel;
          private UsersModels usersModels;

          public UserControlViewModel() {
               InitializeComponent();
               SeputControllers();
               LoadDataGridTable(usersFile.Abrir());
          }

          public void SeputControllers() {
               usersViewModel = new UsersViewModelController(this);
               usersFile = new UsersFile();
               usersModels = new UsersModels();

               ButtonNew.Click += new RoutedEventHandler(usersViewModel.ButtonHandler);
               ButtonModific.Click += new RoutedEventHandler(usersViewModel.ButtonHandler);
               DataGridTable.MouseDown += new MouseButtonEventHandler(usersViewModel.MouseClick);
          }

          public UsersModels GetUsers() {
               usersModels.name = TextBoxName.Text.Replace(" ","").Trim();
               usersModels.password = TextBoxPassword.Text.Replace(" ","").Trim();
               usersModels.type = GetTypeUser();
               return usersModels;
          }

          public List<UsersModels> GetUsersList() {
               List<UsersModels> listas = new List<UsersModels>();
               listas.Add(GetUsers());
               return listas;
          }

          public void LoadDataGridTable(List<UsersModels> listas) {
               DataGridTable.Items.Clear();
               foreach (var v in listas) {
                    DataGridTable.Items.Add(v);
               }
          }

          public void SetUsersTextBox(UsersModels usuariosModels) {
               TextBoxName.Text = usuariosModels.name;
               TextBoxPassword.Text = usuariosModels.password;
               SetTypeUser(usuariosModels.type);
          }

          private string GetTypeUser() {
               string v = "";
               if (RadioUser.IsChecked == true) {
                    v = "Usuario";
               }
               if (RadioAdmi.IsChecked == true) {
                    v = "Administrador";
               }
               return v;
          }

          private void SetTypeUser(string m) {
               if (m.Equals("Usuario")) {
                    RadioUser.IsChecked = true;
               } else {
                    RadioAdmi.IsChecked = true;
               }
          }

          public int RemoveAtDataGridTable() {
               int index = GetDataGridTableSelectdIndex();
               DataGridTable.Items.RemoveAt(index);
               return index;
          }

          public int GetDataGridTableSelectdIndex() {
               return DataGridTable.SelectedIndex;
          }

          public void ClearUsersTextBox() {
               TextBoxName.Clear();
               TextBoxPassword.Clear();
               RadioAdmi.IsChecked = false;
               RadioUser.IsChecked = false;
          }
     }
}