using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
               usuarioArchivos = new UsuarioArchivos();
               CargarDataGridTable(usuarioArchivos.Abrir());
          }

          public void CargarDataGridTable(List<UsuariosModels> listas) {
               DataGridTable.Items.Clear();
               foreach (var v in listas) {
                    DataGridTable.Items.Add(v);
               }
          }

          public void SeputControllers() {
               usuarioControllersAdm = new UsuarioControllersAdm(this);
               ButtonNew.Click += new RoutedEventHandler(usuarioControllersAdm.ButtonHandler);
          }

          public List<UsuariosModels> GetUser() {
               usuariosModels = new UsuariosModels();
               List<UsuariosModels> listas = new List<UsuariosModels>();
               usuariosModels.nombre = TextBoxName.Text;
               usuariosModels.clave = TextBoxPassword.Text;
               usuariosModels.tipoU = TextBoxUserType.Text;
               listas.Add(usuariosModels);
               return listas;
          }

          private void DataGridTable_MouseDoubleClick_1(object sender,MouseButtonEventArgs e) {
               try {
                    MessageBox.Show("Fila ");
               } catch (Exception) {

               }
          }
     }
}
