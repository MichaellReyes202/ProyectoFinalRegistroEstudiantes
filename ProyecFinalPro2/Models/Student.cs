using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Models
{
    class Student
    {

        public string GrupBox { get; set; }
        public int ComboTurno { get; set; }
        public string NyABox { get; set; }
        public string CarnetBox { get; set; }
        public bool SolteroRadio { get; set; }
        public bool CasadoRadio { get; set; }
        public bool MRadio { get; set; }
        public bool FRadio { get; set; }
        public string LyFBox { get; set; }
        public string AgeBox { get; set; }
        public int ComboNacional { get; set; }
        public int ComboDepart { get; set; }
        public int ComboMuni { get; set; }
        public string DirectBox { get; set; }
        public string TelfBox { get; set; }
        public string CelBox { get; set; }
        public string EmailBox { get; set; }
        public string CentroBox { get; set; }
        public bool EstaRadio{ get; set; }
        public bool PrivRadio { get; set; }
        public bool SubvRadio { get; set; }
        public bool OrdiRadio{ get; set; }
        public bool BecRadio { get; set; }
        public bool TrabRadio { get; set; }
        public bool TrabajaSRadio { get; set; }
        public bool TrabajaNRadio { get; set; }
        public bool NIngrRadio { get; set; }
        public bool ReingreRadio { get; set; }
        public bool TrasIntRadio { get; set; }
        public bool TrasExteRadio { get; set; }
        public bool ContCarrRadio { get; set; }
        public bool SegCarrRadio { get; set; }
        
        public static string Title() 
        {
            return "HOJA DE MATRICULA CURSO ELECTIVO "+Year()+"\nPROGRAMA DE MODALIDAD ESPECIAL (PROMECYS)";
        }

        public static string Day() 
        {
            return DateTime.Now.ToString("dd");
        }

        public static string Moth()
        {
            return DateTime.Now.ToString("MM");
        }

        public static string Year()
        {
            return DateTime.Now.ToString("yyyy");
        }


    }
}
