
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


<<<<<<< HEAD
        public List<Models_Registros> GetPeople()
        {
            List<Models_Registros> output = new List<Models_Registros>();

            try
            {
                using (Stream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
=======
          public List<Models_Registros> GetPeople() {
               List<Models_Registros> output = new List<Models_Registros>();

               try {

                    using (Stream fs = new FileStream(ruta,FileMode.Open,FileAccess.Read)) {
                         using (StreamReader sr = new StreamReader(fs)) {
                              while (!sr.EndOfStream) {
                                   line = sr.ReadLine();
>>>>>>> f89e0bec2bb7f6fde5668fd5fef17ba58a21da09

                                   Particion(line);
                                   //MessageBox.Show(line);

                                   output.Add(new Models_Registros { nombre = parte1,carnet = parte2,RutaMatriculas = ListaRuta_Matricula() });

                              }
                         }
                    }

               } catch (Exception) {

                    MessageBox.Show("Prueba");
               }

<<<<<<< HEAD
                MessageBox.Show("Prueba");
            }
            return output;
        }
=======

               try {
                    using (Stream fs = new FileStream(ruta,FileMode.Open,FileAccess.Read)) {
                         using (StreamReader sr = new StreamReader(fs)) {
                              while (!sr.EndOfStream) {
                                   line = sr.ReadLine();
                                   Particion(line);


                                   //MessageBox.Show(line);  
                                   //output.Add(new Models_Registros { nombre = parte1,carnet = parte2,NombreMatriculas = ListasNombre_Matricula(),RutaMatriculas = ListaRuta_Matricula() });

                              }
                         }
                    }

               } catch (Exception x) {
                    System.Windows.MessageBox.Show("Ocurrio un problema");
               }
>>>>>>> f89e0bec2bb7f6fde5668fd5fef17ba58a21da09


               return output;

          }
          //---------------------------------------------------------------------

          // Divide la cadena que recibe del archivo donde estan todos los estudiantes        
          private void Particion(String Datos) {
               string[] particion = Datos.Split("-");
               parte1 = particion[0];
               parte2 = particion[1];
          }


          private List<FileInfo> ListaRuta_Matricula() {
               List<FileInfo> Rutas = new List<FileInfo>();
               DirectoryInfo info = new DirectoryInfo(path + parte2);

<<<<<<< HEAD
            foreach (FileInfo fi in info.GetFiles())
            {
                Rutas.Add(fi);
                

            }
            return Rutas;


            
        }
    }

=======
               foreach (FileInfo fi in info.GetFiles()) {
                    Rutas.Add(fi);

               }
               return Rutas;
          }


     }
>>>>>>> f89e0bec2bb7f6fde5668fd5fef17ba58a21da09
}

