using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Interfaz
{
     interface IGestionArchivos<T>
     {
          void Guardar(T obj, string carpeta, string txt);

          void Guardar(List<T> listas, bool v);

          List<T> Abrir();

          void Modificar();

          void Eliminar();
     }
}
