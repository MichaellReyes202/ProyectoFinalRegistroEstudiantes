
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System;
using System.Windows.Shapes;

namespace ProyecFinalPro2.Models
{
    public class DataAccess
    {

        private string ruta = @"./RegistroEstudiantes/ListaUsuarios.txt";
        private string path = @"RegistroEstudiantes/";



        private string parte1;  // hace referencia al nombre
        private string parte2;  // hace referencial al carnet
        private string line;


        public List<Models_Registros> GetPeople()
        {
            List<Models_Registros> output = new List<Models_Registros>();
<<<<<<< HEAD

=======
<<<<<<< HEAD
            
      
            try
            {

=======
>>>>>>> e72bd6716258c2753bcf82e82942796f6cae8fc6
            try {
                
>>>>>>> 16b07255c3a3adfa3abcdfa3ff0dd2826a34f468
                using (Stream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();

                            Particion(line);
                            //MessageBox.Show(line);

                            output.Add(new Models_Registros { nombre = parte1, carnet = parte2, RutaMatriculas = ListaRuta_Matricula() });

                        }
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Prueba");
            }
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======
>>>>>>> e72bd6716258c2753bcf82e82942796f6cae8fc6

               try {
                    using (Stream fs = new FileStream(ruta,FileMode.Open,FileAccess.Read)) {
                         using (StreamReader sr = new StreamReader(fs)) {
                              while (!sr.EndOfStream) {
                                   line = sr.ReadLine();
                                   Particion(line);


                                   //MessageBox.Show(line);

                                   output.Add(new Models_Registros { nombre = parte1,carnet = parte2,NombreMatriculas = ListasNombre_Matricula(),RutaMatriculas = ListaRuta_Matricula() });

                              }
                         }
                    }

               } catch (Exception x) {
                    System.Windows.MessageBox.Show("Ocurrio un problema");
               }
           
<<<<<<< HEAD

=======
>>>>>>> 16b07255c3a3adfa3abcdfa3ff0dd2826a34f468
>>>>>>> e72bd6716258c2753bcf82e82942796f6cae8fc6
            return output;
        }

        //---------------------------------------------------------------------

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
            DirectoryInfo info = new DirectoryInfo(path + parte2);

            foreach (FileInfo fi in info.GetFiles())
            {
                Rutas.Add(fi);

            }
            return Rutas;
        }


    }
}
