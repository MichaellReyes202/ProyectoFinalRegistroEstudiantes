using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Interfaz
{
     interface IGestionSerializar<T>
     {
          void Guardar(T obj);

          List<T> Abrir();

          void Modificar();

          void Eliminar();
     }
}
