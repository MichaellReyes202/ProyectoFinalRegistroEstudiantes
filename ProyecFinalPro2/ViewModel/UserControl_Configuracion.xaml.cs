using ProyecFinalPro2.Controller;
using ProyecFinalPro2.Views;
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



namespace ProyecFinalPro2.ViewModel
{

    public partial class UserControl_Configuracion : UserControl
    {
        private Confi_Controller ctrl;
        private MainFrame main;

        public UserControl_Configuracion()
        {
            InitializeComponent();
            SetupController();
        }

        private void SetupController()
        {
            ctrl = new Confi_Controller(this);
            Selec_Carpet.Click += new RoutedEventHandler(ctrl.Buscar_Click);
        }

        public void setUbicacion(string u)
        {
            Ubicacion.Text = u;
        }

        public string getUbicacion()
        {
            return Ubicacion.Text;
        }

        

        
    }
}
