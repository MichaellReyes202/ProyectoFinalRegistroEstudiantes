using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Models
{
    // [Serializable]
     public class UsuarioModels
     {
          public string clave { get; set; }
          public string nombre { get; set; }

          // True adminstrador, False usuario
          public bool? tipoUsuario { get; set; }
     }
}
