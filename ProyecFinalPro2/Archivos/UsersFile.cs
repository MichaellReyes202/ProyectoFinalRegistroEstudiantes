using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.Interfaz;
using ProyecFinalPro2.Models;
using System.IO;
using System.Windows;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyecFinalPro2.Archivos
{
     class UsersFile : IGestionArchivos<UsersModels>
     {
          private string path = @"Datos Usuarios\";
          private BinaryFormatter binaryFormatter;
          private List<UsersModels> listas;
          private string contenido;

          public UsersFile() {
               binaryFormatter = new BinaryFormatter();
          }

          public List<UsersModels> Abrir() {
               listas = new List<UsersModels>();

               try {
                    StreamReader streamReader = new StreamReader(path + "ListaUsuarios.txt");
                    while ((contenido = streamReader.ReadLine()) != null) {
                         string[] delimitador = contenido.Split(",");
                         UsersModels usersModels = new UsersModels();
                         usersModels.name = delimitador[0];
                         usersModels.password = delimitador[1];
                         usersModels.type = delimitador[2];
                         listas.Add(usersModels);
                    }
                    streamReader.Close();
               } catch (Exception) { }
               return listas;
          }

          public void Guardar(List<UsersModels> listas,bool v) {
               if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

               try {
                    StreamWriter streamWriter = new StreamWriter(path + "ListaUsuarios.txt",v);
                    foreach (UsersModels u in listas) {
                         streamWriter.WriteLine(u.name + "," + u.password + "," + u.type);
                    }
                    streamWriter.Flush(); streamWriter.Close();

               } catch (Exception) { }
          }

          public void Guardar(UsersModels obj,string carpeta,string txt) {
               throw new NotImplementedException();
          }
          public void Eliminar() { throw new NotImplementedException(); }

          public void Modificar() { throw new NotImplementedException(); }
     }
}
