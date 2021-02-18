
using ProyecFinalPro2.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ProyecFinalPro2.ViewModel
{

    public partial class UserControl_BD_Student : UserControl
    {
        private DataAccess da;
        public UserControl_BD_Student()
        {
            InitializeComponent();

            /*da = new DataAccess();

            List<Models_Registros> per = da.GetPeople();

            People.DataContext = per;*/

            da = new DataAccess();

            List<Models_Registros> per = da.GetPeople();

            People.DataContext = per;

        }

        private void Actulizar_Click(object sender, RoutedEventArgs e)
        {
            da = new DataAccess();

            List<Models_Registros> per = da.GetPeople();

            

            People.DataContext = per;
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock ls = (TextBlock)sender;

            FileInfo f = new FileInfo("" + ls.DataContext);

            MessageBox.Show("El indice es = "+f.DirectoryName);


        }

        
        private void TextBlock_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("La matrucula seleccionada fue : " );
        }

        private void MenuContextual_Matricula_Click(object sender, RoutedEventArgs e)
        {
            MenuItem selection = (MenuItem)sender;

            switch(selection.Name)
            {
                case "Modificar_Matricula":
                    {

                        MessageBox.Show("Has seleccionado Modificar La Matricula");
                    }
                    break;
                case "Eliminar_Matricula":
                    {
                        MessageBox.Show("Has seleccionado Elimiar La Matricula");
                    }
                    break;
            }
        }
    }
}
