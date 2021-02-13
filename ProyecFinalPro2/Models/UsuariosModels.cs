using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Models
{
     public class UsuariosModels
     {
          public string clave { get; set; }
          public string nombre { get; set; }

          // True adminstrador, False usuario
          public string tipoU { get; set; }
     }
}
