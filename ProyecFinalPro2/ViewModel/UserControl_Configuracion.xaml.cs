using ProyecFinalPro2.Controller;
using ProyecFinalPro2.Views;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Controls;


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
            setInicioRuta();
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

        private void setInicioRuta()
        {
            string actual = ConfigurationManager.AppSettings.Get("RutaActual");
            if(actual.Equals(""))
            {
                string defecto = ConfigurationManager.AppSettings.Get("RutaDefecto");
                DirectoryInfo inf = new DirectoryInfo(defecto);
                Ubicacion.Text = inf.FullName;
            }
            else{Ubicacion.Text = actual;}
        }


        

        
    }
}
