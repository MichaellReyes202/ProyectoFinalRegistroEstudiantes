using ProyecFinalPro2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using ProyecFinalPro2.Interfaz;
using System.Runtime.Serialization.Formatters.Binary;


namespace ProyecFinalPro2.Archivos
{
    class EstudiantesArchivos : IGestionArchivos<Student> {

        string path = @"RegistroEstudiantes\";
        string contenido;
        private BinaryFormatter Binar = new BinaryFormatter();
        private List<Student> Lista;

        public List<Student> Abrir()
        {
            Lista = new List<Student>();

            try
            {
                StreamReader streamReader = new StreamReader(path + "ListaUsuarios.txt");
                while ((contenido = streamReader.ReadLine()) != null)
                {
                    string[] delimitador = contenido.Split("-");
                    
                    Student Estudiante = new Student();
                    Estudiante.NyABox = delimitador[0];
                    Estudiante.CarnetBox = delimitador[1];
                    Lista.Add(Estudiante);
                    MessageBox.Show(contenido);
                }
                streamReader.Close();
            }
            catch (Exception) { MessageBox.Show("Error Archivo Read"); }
            return Lista;
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Guardar(List<Student> Lista, bool v)
        {
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

            try
            {
                StreamWriter streamWriter = new StreamWriter(path + "ListaUsuarios.txt", v);
                foreach (Student u in Lista)
                {
                    streamWriter.WriteLine(u.NyABox + "-" + u.CarnetBox);
                }
                streamWriter.Flush(); streamWriter.Close();

            }
            catch (Exception) { MessageBox.Show("Error Archvio Write"); }
        }

        public void ller(string u) 
        {
            Student Estudiante = new Student();
            Stream stream = new FileStream(path+u,FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
            Estudiante = (Student) Binar.Deserialize(stream);
        }

        public void Guardar(Student Est, string carpeta , string txt)
        {
            
            if (!Directory.Exists(path+carpeta)) { Directory.CreateDirectory(path+carpeta+"\\"); }
            try
            {
                Stream stream = new FileStream(path + carpeta + "\\"+ txt, FileMode.Create, FileAccess.Write, FileShare.None);
                Binar.Serialize(stream, Est);
                stream.Flush(); stream.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("No serializar");
            }
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public List<string> BuscarDirectorio( string carnet ) 
        {
            List<string> directorios = new List<string>();
            DirectoryInfo directInfo = new DirectoryInfo(path+carnet);
            foreach (var direct in directInfo.GetFiles()) 
            {
                directorios.Add(direct.FullName);
            
            }
            return directorios;
        }
    }
}
