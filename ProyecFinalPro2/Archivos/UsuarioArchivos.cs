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
     class UsuarioArchivos : IGestionArchivos<UsuarioModels>
     {
          private string path = @"c:\DatosUsuarios\";
          private BinaryFormatter binaryFormatter;

          public UsuarioArchivos() {
               binaryFormatter = new BinaryFormatter();
          }

          public List<UsuarioModels> Abrir() {
               throw new NotImplementedException();
          }

          public void ller() {
               UsuarioModels usuarioModels = new UsuarioModels();
               Stream stream = new FileStream(path + "Usuario.txt",FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
               usuarioModels = (UsuarioModels) binaryFormatter.Deserialize(stream);

               MessageBox.Show("Nombre : " + usuarioModels.nombre + " Clave: " + usuarioModels.clave + " " + usuarioModels.tipoUsuario);
          }

          public void Eliminar() {
               throw new NotImplementedException();
          }

          public void Guardar(UsuarioModels usuario) {
               if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
               try {
                    Stream stream = new FileStream(path + "Usuario.txt",FileMode.Create,FileAccess.Write,FileShare.None);
                    binaryFormatter.Serialize(stream,usuario);
                    stream.Flush(); stream.Close();
               } catch (Exception x) {
                    MessageBox.Show("No");
               }
          }

          public void Modificar() {
               throw new NotImplementedException();
          }

          public void Guardar(List<UsuarioModels> listas,bool v) {

               try {
                    StreamWriter streamWriter = new StreamWriter(path + "Us.txt",v);
                    foreach (UsuarioModels usuarioModels in listas) {
                         MessageBox.Show("si");
                         streamWriter.WriteLine(usuarioModels.nombre + "-" + usuarioModels.clave + "-" + usuarioModels.tipoUsuario);
                    }
                    streamWriter.Flush(); streamWriter.Close();

               } catch (Exception x) {
                    MessageBox.Show("No");
               }
          }
     }
}
