using ProyecFinalPro2.ViewModel;
using System.Windows;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ProyecFinalPro2.Controller
{
    public class Confi_Controller
    {
        private UserControl_Configuracion lol;

        public Confi_Controller(UserControl_Configuracion ucf)
        {
            this.lol = ucf;
        }

        public void Buscar_Click(object sender, RoutedEventArgs e)
        {
            
            string origen = ConfigurationManager.AppSettings.Get("RutaDefecto");
            string destino = ConfigurationManager.AppSettings.Get("RutaActual");
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {   
                DirectoryInfo info = new DirectoryInfo(origen);
                string completa = folder.SelectedPath + @"\RegistroEstudiantes";


                if(Directory.Exists(completa))
                {
                    System.Windows.MessageBox.Show("El directorio no valido, ya existe una carpete con el mismo nombres");
                }
                else
                {
                    if (destino == "")
                    {
                        System.IO.Directory.Move(info.FullName, completa);
                    }
                    else
                    {
                        System.IO.Directory.Move(destino, completa);
                    }
                    Configuration confi = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    confi.AppSettings.Settings["RutaActual"].Value = completa;
                    confi.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    lol.setUbicacion(completa);
                    
                }

            }
        }
    }
}
