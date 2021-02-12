
using ProyecFinalPro2.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace ProyecFinalPro2.ViewModel
{
    /// <summary>
    /// Lógica de interacción para UserControlDashboard.xaml
    /// </summary>
    public partial class UserControl_BD_Student : UserControl
    {

        public UserControl_BD_Student()
        {
            InitializeComponent();

            DataAccess da = new DataAccess();

            List<Models_Registros> per = da.GetPeople();

            People.DataContext = per;

            //foreach (Models_Registros v in per)
            //{
            //    MessageBox.Show("Mierda");
            //    People.Items.Add(v);
            //}

        }

    }
}
