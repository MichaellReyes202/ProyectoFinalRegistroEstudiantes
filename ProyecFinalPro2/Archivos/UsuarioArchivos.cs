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
     class UsuarioArchivos : IGestionArchivos<UsuariosModels>
     {
          private string path = @"Datos Usuarios\";
          private BinaryFormatter binaryFormatter;
          private List<UsuariosModels> listas;
          private string contenido;

          public UsuarioArchivos() {
               binaryFormatter = new BinaryFormatter();
          }

          public List<UsuariosModels> Abrir() {
               listas = new List<UsuariosModels>();

               try {
                    StreamReader streamReader = new StreamReader(path + "ListaUsuarios.txt");
                    while ((contenido = streamReader.ReadLine()) != null) {
                         string[] delimitador = contenido.Split(",");
                         UsuariosModels usuario = new UsuariosModels();
                         usuario.nombre = delimitador[0];
                         usuario.clave = delimitador[1];
                         usuario.tipoU = delimitador[2];
                         listas.Add(usuario);
                    }
                    streamReader.Close();
               } catch (Exception) { }

               return listas;
          }

          public void Guardar(List<UsuariosModels> listas,bool v) {
               if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

               try {
                    StreamWriter streamWriter = new StreamWriter(path + "ListaUsuarios.txt",v);
                    foreach (UsuariosModels u in listas) {
                         streamWriter.WriteLine(u.nombre + "," + u.clave + "," + u.tipoU);
                    }
                    streamWriter.Flush(); streamWriter.Close();

               } catch (Exception x) { MessageBox.Show("Errro Archvio Write"); }
          }

          //public void ller() {
          //     UsuarioModels usuarioModels = new UsuarioModels();
          //     Stream stream = new FileStream(path + "Usuario.txt",FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
          //     usuarioModels = (UsuarioModels) binaryFormatter.Deserialize(stream);
          //}

          public void Eliminar() {
               throw new NotImplementedException();
          }

          public void Guardar(UsuariosModels usuario, string a , string b) {
               if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
               try {
                    Stream stream = new FileStream(path + "Usuario.txt",FileMode.Create,FileAccess.Write,FileShare.None);
                    binaryFormatter.Serialize(stream,usuario);
                    stream.Flush(); stream.Close();
               } catch (Exception x) {
                    MessageBox.Show("No serializar");
               }
          }
          public void Modificar() {
               throw new NotImplementedException();
          }
     }
}
