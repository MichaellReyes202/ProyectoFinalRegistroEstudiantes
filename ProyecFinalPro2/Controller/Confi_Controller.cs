using ProyecFinalPro2.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;



using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using ProyecFinalPro2.Views;
using ProyecFinalPro2.Models;
using DocumentFormat.OpenXml.CustomProperties;

namespace ProyecFinalPro2.Controller
{
    public class Confi_Controller
    {
        private UserControl_Configuracion lol;

        private string temporal = "";

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
