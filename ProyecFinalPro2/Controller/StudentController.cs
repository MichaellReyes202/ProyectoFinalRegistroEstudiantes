using ProyecFinalPro2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using ProyecFinalPro2.Archivos;
using ProyecFinalPro2.Models;

namespace ProyecFinalPro2.Controller
{
    class StudentController
    {
        private UserControlStudent Controlestudiante;

        public StudentController(UserControlStudent est)
        {
            Controlestudiante= est;   
        }

        public void Guardar(object sender, RoutedEventArgs e)
        {
            EstudiantesArchivos estudiantesarchivo = new EstudiantesArchivos();
            
            if (!buscar_carnet(estudiantesarchivo.Abrir())) 
            {
                estudiantesarchivo.Guardar(Controlestudiante.getestudiantes(), true);
            }
            estudiantesarchivo.Guardar(Controlestudiante.getAll(),Controlestudiante.mandar_carnet(),"Matriculado el "+Controlestudiante.mandar_fecha()+".txt");
           
        }

        public bool buscar_carnet(List<Student> a) 
        {
            foreach (Student guard in a) 
            {
                if ( guard.CarnetBox.Equals(Controlestudiante.mandar_carnet())) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
