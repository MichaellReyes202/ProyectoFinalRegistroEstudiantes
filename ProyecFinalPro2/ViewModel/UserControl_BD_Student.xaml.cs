
using ProyecFinalPro2.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


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
            

        }

        private void Actulizar_Click(object sender, RoutedEventArgs e)
        {
            da = new DataAccess();

            List<Models_Registros> per = da.GetPeople();

            People.DataContext = per;
        }

        private void People_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            da = new DataAccess();

            List<Models_Registros> per = da.GetPeople();

            People.DataContext = per;
        }
    }
}
