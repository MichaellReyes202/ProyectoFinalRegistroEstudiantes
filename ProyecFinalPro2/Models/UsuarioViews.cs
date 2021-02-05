using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Models
{
     [Serializable]
     public class UsuarioViews
     {
          public string clave { get; set; }
          public string nombre { get; set; }
          public bool? tipoUsuario { get; set; }
     }
}
