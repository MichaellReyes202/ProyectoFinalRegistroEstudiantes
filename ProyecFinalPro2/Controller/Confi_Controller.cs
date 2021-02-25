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

                if (destino == "" && temporal=="")
                {
                    try
                    {
                        System.IO.Directory.Move(info.FullName, folder.SelectedPath + @"\RegistroEstudiantes");
                        temporal = folder.SelectedPath + @"\RegistroEstudiantes";
                        
                    }
                    catch(DirectoryNotFoundException ex)
                    {
                        System.Windows.MessageBox.Show("Direccion ya existente");
                    }   
                }
                else
                {
                    System.IO.Directory.Move(destino, folder.SelectedPath+ @"\RegistroEstudiantes");
                }

                Configuration confi = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                confi.AppSettings.Settings["RutaActual"].Value = folder.SelectedPath + @"\RegistroEstudiantes";
                confi.Save(ConfigurationSaveMode.Modified);
                
                ConfigurationManager.RefreshSection("appSettings");

                lol.setUbicacion(folder.SelectedPath + @"\RegistroEstudiantes");


            }
        }
    }
}
