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

namespace ProyecFinalPro2.ViewModel
{
     public partial class UserControlUsuario : UserControl
     {
          private UsuarioArchivos usuarioArchivos;

          public UserControlUsuario() {
               InitializeComponent();
               usuarioArchivos = new UsuarioArchivos();
               CargarDataGridTable(usuarioArchivos.Abrir());
               CargarDataGridTable(usuarioArchivos.Abrir());
               CargarDataGridTable(usuarioArchivos.Abrir());
               CargarDataGridTable(usuarioArchivos.Abrir());
          }

          public void CargarDataGridTable(List<UsuariosModels> listas) {
               foreach (var v in listas) {
                    DataGridTable.Items.Add(v);
               }
          }
     }
}
