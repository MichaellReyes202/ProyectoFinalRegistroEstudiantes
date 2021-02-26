
using ProyecFinalPro2.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using ProyecFinalPro2.Views;
using ProyecFinalPro2.Controller;

namespace ProyecFinalPro2.ViewModel
{

    public partial class UserControl_BD_Student : UserControl
    {
        private DataAccess da;

        private BD_Controller BD_Ctrl;


        public UserControl_BD_Student()
        {
            
            InitializeComponent();
            SeputControllers();
            da = new DataAccess();
            People.DataContext = da.GetPeople();

        }

        private void SeputControllers()
        {
            BD_Ctrl = new BD_Controller(this);
            


        }
        public void ButtonActualizar_Matricula_Click(object sender, RoutedEventArgs e)
        {
            refrescar();
        }
        public void MenuContextual_Matricula_Click(object sender, RoutedEventArgs e)
        {
            MenuItem selection = (MenuItem)sender;
            FileInfo fl = new FileInfo("" + selection.DataContext);
            switch (selection.Name)
            {

                case "Modificar":
                    {
                        if(fl.Exists)
                        {
                            VentanaDataGrid ventana = new VentanaDataGrid(fl);
                            ventana.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("La ruta de los archivos fue modificada , actualiza la tabla");
                        }
                        
                    }
                    break;
                case "Eliminar":
                    {
                        File.Delete("" + selection.DataContext);
                        refrescar();
                    }
                    break;
            }
        }


        public void refrescar()
        {
            da = new DataAccess();
            People.DataContext = da.GetPeople();
        }
    }
}
