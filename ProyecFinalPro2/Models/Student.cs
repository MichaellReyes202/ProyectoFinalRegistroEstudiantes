using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Models
{
    class Student
    {
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
