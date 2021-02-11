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
            foreach (var lista in estudiantesarchivo.BuscarDirectorio(Controlestudiante.mandar_carnet())) 
            {
                MessageBox.Show(lista);
            }
            //estudiantesarchivo.Guardar(Controlestudiante.getAll(), Controlestudiante.mandar_carnet(), "Matriculado el " + Controlestudiante.mandar_fecha()+"Prueba");
            /*
            switch (buscar_carnet(estudiantesarchivo.Abrir())) 
            {
                case "1": 
                    {
                        estudiantesarchivo.Guardar(Controlestudiante.getAll(), Controlestudiante.mandar_carnet(), "Matriculado el " + Controlestudiante.mandar_fecha()+"Prueba");
                        break;
                    }
                case "2":
                    {
                        estudiantesarchivo.Guardar(Controlestudiante.getAll(),Controlestudiante.mandar_carnet(),"Matriculado el "+Controlestudiante.mandar_fecha());
                        break;
                    }
            
            
            }
            */
            //estudiantesarchivo.Guardar(Controlestudiante.getestudiantes(),true);

        }

        public string buscar_carnet(List<Student> a) 
        {
            foreach (Student guard in a) 
            {
                if ( guard.CarnetBox.Equals(Controlestudiante.mandar_carnet())) 
                {
                    return "1";
                }
            }
            return "2";
        }
    }
}
