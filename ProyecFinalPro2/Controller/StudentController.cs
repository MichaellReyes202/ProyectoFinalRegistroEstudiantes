using ProyecFinalPro2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using ProyecFinalPro2.Archivos;
using ProyecFinalPro2.Models;
using System.Windows.Controls;

namespace ProyecFinalPro2.Controller
{
    class StudentController
    {
        private UserControlStudent Controlestudiante;

        private Student prueba = new Student();
        private int contar;

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
                if (guard.CarnetBox.Equals(Controlestudiante.mandar_carnet()))
                {
                    return true;
                }
            }
            return false;
        }


        public void Nacional_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(Controlestudiante.Obtener_Nacionalidad());
            switch (Controlestudiante.Obtener_Nacionalidad())
            {
                
                case "0":
                    {
                        Controlestudiante.bool_Deparmento(true);
                        if (contar <= 0)
                        {
                            foreach (var u in prueba.departamento)
                            {
                                Controlestudiante.item_Departamento(u);
                            }
                            contar = 1;
                        }
                        break;

                    }
                case "1":
                    {
                        contar = 0;
                        Controlestudiante.limpiar_Departamento();
                        Controlestudiante.limpiar_Municipio();
                        Controlestudiante.bool_Deparmento(false);
                        Controlestudiante.bool_Municipio(false);
                        break;
                    }

            }

        }

        public void Departamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Controlestudiante.Obtener_Departamento() >= 0)
            {
                Controlestudiante.bool_Municipio(true);
                switch (Controlestudiante.Obtener_Departamento())
                {
                    case 0:
                        {
                            Agregar_municipio(prueba.Boaco);
                            break;
                        }
                    case 1:
                        {
                            Agregar_municipio(prueba.Carazo);
                            break;
                        }
                    case 2:
                        {
                            Agregar_municipio(prueba.Chinandega);
                            break;
                        }
                    case 3:
                        {
                            Agregar_municipio(prueba.Chontales);
                            break;
                        }
                    case 4:
                        {
                            Agregar_municipio(prueba.CostaN);
                            break;
                        }
                    case 5:
                        {
                            Agregar_municipio(prueba.CostaS);
                            break;
                        }
                    case 6:
                        {
                            Agregar_municipio(prueba.Estéli);
                            break;
                        }
                    case 7:
                        {
                            Agregar_municipio(prueba.Granada);
                            break;
                        }
                    case 8:
                        {
                            Agregar_municipio(prueba.Jinotega);
                            break;
                        }
                    case 9:
                        {
                            Agregar_municipio(prueba.Leon);
                            break;
                        }
                    case 10:
                        {
                            Agregar_municipio(prueba.Madriz);
                            break;
                        }
                    case 11:
                        {
                            Agregar_municipio(prueba.Managua);
                            break;
                        }
                    case 12:
                        {
                            Agregar_municipio(prueba.Masaya);
                            break;
                        }
                    case 13:
                        {
                            Agregar_municipio(prueba.Matagalpa);
                            break;
                        }
                    case 14:
                        {
                            Agregar_municipio(prueba.NuevaS);
                            break;
                        }
                    case 15:
                        {
                            Agregar_municipio(prueba.RSanJ);
                            break;
                        }
                    case 16:
                        {
                            Agregar_municipio(prueba.RSanJ);
                            break;
                        }
                }
            }
        }

        public void Agregar_municipio(string[] depart)
        {
            Controlestudiante.limpiar_Municipio();
            foreach (var u in depart)
            {
                Controlestudiante.item_Municipio(u);
            }
        }

        public void ComboCuatrimestres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch (cb.SelectedIndex)
            {
                case 0:
                    {
                        agregar_cuatrimestre(prueba.Primero);
                        break;
                    }
                case 1:
                    {
                        agregar_cuatrimestre(prueba.Segundo);
                        break;
                    }
                case 2:
                    {
                        agregar_cuatrimestre(prueba.Tecero);
                        break;
                    }
                case 3:
                    {
                        agregar_cuatrimestre(prueba.Cuarto);
                        break;
                    }
            }
        }

        public void agregar_cuatrimestre(string[] clase)
        {
            Controlestudiante.limpiar_Inscribir();
            foreach (var u in clase)
            {
                if (!Controlestudiante.contenedor_Inscrito(u))
                {
                    Controlestudiante.items_Inscribir(u);
                }
            }

        }


    }
}
