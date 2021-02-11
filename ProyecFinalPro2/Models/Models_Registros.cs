using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyecFinalPro2.Models
{
    public class Models_Registros
    {
        public string nombre { get; set; }
        public string carnet { get; set; }

        public List<string> NombreMatriculas { get; set; } = new List<string>();
        public List<FileInfo> RutaMatriculas { get; set; } = new List<FileInfo>();
        
        
        
        
        //public string Nombre { get => nombre; set => nombre = value; }
        //public string Carnet { get => carnet; set => carnet = value; }
    }
}
