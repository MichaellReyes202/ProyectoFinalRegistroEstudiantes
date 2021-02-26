
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System;
using System.Windows.Shapes;
using System.Configuration;
using ProyecFinalPro2.Controller;
using ProyecFinalPro2.ViewModel;

namespace ProyecFinalPro2.Models
{
    public class DataAccess
    {
        private string ruta = @"./RegistroEstudiantes/ListaUsuarios.txt";
        private string path = @"RegistroEstudiantes/";
        private string parte1;  // hace referencia al nombre
        private string parte2;  // hace referencial al carnet
        private string line;

        public DataAccess()
        {
            //this.con = con;
            setRuta();
        }
        public void setRuta()
        {
            string destino = ConfigurationManager.AppSettings.Get("RutaActual");
            MessageBox.Show("ruta en DAtaAcces = " + destino); 

            ConfigurationManager.RefreshSection("appSettings");
            
            DirectoryInfo info = new DirectoryInfo(path);

            if (destino != "")
            {
                if(info.FullName != destino )
                {
                    ruta = ConfigurationManager.AppSettings.Get("RutaActual") + @"\ListaUsuarios.txt";
                    MessageBox.Show("Valor de la ruta = " + ruta);
                    path = destino+@"\";
                }
            }
        }

        public List<Models_Registros> GetPeople()
        {
            List<Models_Registros> output = new List<Models_Registros>();
            try {
                
                using (Stream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            Particion(line);
                            output.Add(new Models_Registros { nombre = parte1, carnet = parte2, RutaMatriculas = ListaRuta_Matricula() });
                        }
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un Error");
            }

            return output;
        }


        // Divide la cadena que recibe del archivo donde estan todos los estudiantes        
        private void Particion(String Datos)
        {
            string[] particion = Datos.Split("-");

            parte1 = particion[0];
            parte2 = particion[1];

        }


        private List<FileInfo> ListaRuta_Matricula()
        {
            List<FileInfo> Rutas = new List<FileInfo>();
            DirectoryInfo info = new DirectoryInfo(path+parte2);

            foreach (FileInfo fi in info.GetFiles())
            {
                Rutas.Add(fi);

            }
            return Rutas;
        }


    }
}
