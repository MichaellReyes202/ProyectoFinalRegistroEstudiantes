using ProyecFinalPro2.Archivos;
using ProyecFinalPro2.Models;
using ProyecFinalPro2.Views;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProyecFinalPro2.Controller
{
    class StudentController
    {
        private UserControlStudent Controlestudiante;

        private Student prueba = new Student();
        private int contar; int count;

        public StudentController(UserControlStudent est)
        {
            Controlestudiante = est;
        }

        public void Guardar(object sender, RoutedEventArgs e)
        {
            EstudiantesArchivos estudiantesarchivo = new EstudiantesArchivos();
            if (Controlestudiante.carnet_leng() == 10 && !string.IsNullOrEmpty(Controlestudiante.verificar_nombre()) && Controlestudiante.contador_Incrito() >= 1)
            {
                if (!buscar_carnet(estudiantesarchivo.Abrir()))
                {
                    estudiantesarchivo.Guardar(Controlestudiante.getestudiantes(), true);
                }
                estudiantesarchivo.Guardar(Controlestudiante.getAll(), Controlestudiante.mandar_carnet(), "Matriculado el " + Controlestudiante.mandar_fecha() + ".txt");
            }
            else
            {
                MessageBox.Show("Error, revise los campos obligatoria: Carnet, Nombre y Clases Inscritas");
            }
        }

        public void Limpiar_Hoja(object sender, RoutedEventArgs e)
        {
            Controlestudiante.limpiar_todo();
        }

        public void Imprimir(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                pd.PrintVisual(Controlestudiante.Hoja_Registro, "Hoja 1");
            }

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
            switch (Controlestudiante.Obtener_Nacionalidad())
            {
                case 0:
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
                case 1:
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
            refrescar();
        }

        public void refrescar()
        {
            switch (Controlestudiante.select_ComboCuatrimestre())
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
                case 4:
                    {
                        agregar_cuatrimestre(prueba.Quinto);
                        break;
                    }
                case 5:
                    {
                        agregar_cuatrimestre(prueba.Sexto);
                        break;
                    }
                case 6:
                    {
                        agregar_cuatrimestre(prueba.Septimo);
                        break;
                    }
                case 7:
                    {
                        agregar_cuatrimestre(prueba.Octavo);
                        break;
                    }
                case 8:
                    {
                        agregar_cuatrimestre(prueba.Noveno);
                        break;
                    }
                case 9:
                    {
                        agregar_cuatrimestre(prueba.Decimo);
                        break;
                    }
                case 10:
                    {
                        agregar_cuatrimestre(prueba.DecimoPrimero);
                        break;
                    }
                case 11:
                    {
                        agregar_cuatrimestre(prueba.DecimoSegundo);
                        break;
                    }
                case 12:
                    {
                        agregar_cuatrimestre(prueba.DecimoTercero);
                        break;
                    }
                case 13:
                    {
                        agregar_cuatrimestre(prueba.DecimoCuarto);
                        break;
                    }
                case 14:
                    {
                        agregar_cuatrimestre(prueba.DecimoQuinto);
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
                    Controlestudiante.agregar_Inscribir(u);
                }
            }

        }

        public void ListBoxButtons_Click(object sender, RoutedEventArgs e)
        {
            Button bb = (Button)sender;
            switch (bb.Name)
            {
                case "Mandar":
                    {
                        try
                        {
                            if (!Controlestudiante.prueba())
                            {
                                if (Controlestudiante.contador_Incrito() <= 5)
                                {
                                    Controlestudiante.selected_Inscrito();
                                }
                                else
                                {
                                    MessageBox.Show("Solo se pueden incribir un maximo de 6 clases");
                                }

                            }
                        }
                        catch (Exception) { }
                        break;
                    }
                case "Mandar_Todo":
                    {
                        foreach (var u in Controlestudiante.items_Inscribir())
                        {
                            if (Controlestudiante.contador_Incrito() <= 5)
                            {
                                Controlestudiante.agregar_Inscrito(u.ToString());
                            }
                            else
                            {
                                if (contar == 1)
                                {
                                    MessageBox.Show("Solo se pueden incribir un maximo de 6 clases");
                                }
                                contar++;
                            }
                        }
                        Controlestudiante.limpiar_Inscribir();
                        refrescar();
                        break;
                    }
                case "Remove":
                    {
                        Controlestudiante.remove_Inscrito();
                        refrescar();
                        break;
                    }
                case "RemoveAll":
                    {
                        Controlestudiante.limpiar_Inscrito();
                        refrescar();
                        break;
                    }

            }
            contar = 0;
        }

        public void Valida_letras(object sender, TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if (character >= 65 && character <= 90 || character >= 97 && character <= 122 || character == 209 || character == 241)
            {
                e.Handled = false;
            }
            else { MessageBox.Show("Solo se permiten letras"); e.Handled = true; }
        }

        public void Valida_Carnet(object sender, TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            count = Controlestudiante.carnet_leng();
            if (character >= 48 && character <= 57 && count != 9)
            {
                if (count <= 8)
                {
                    if (count.Equals(5)) { Controlestudiante.carnet_texto(count, " "); e.Handled = false; }
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (count == 9)
                {
                    if (character >= 65 && character <= 90)
                    {
                        e.Handled = false;
                    }
                    else { MessageBox.Show("El ultimo caracter debe de ser una letra Mayuscula"); e.Handled = true; }
                }
                else
                {
                    MessageBox.Show("Solo se permiten Numeros");
                    e.Handled = true;
                }

            }

        }

        public void valida_telefono(object sender, TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            count = Controlestudiante.telefono_leng();
            if (character >= 48 && character <= 57 && count != 9)
            {
                if (count <= 7)
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Los numeros de telefono constan de 8 digitos");
                    e.Handled = true;
                }

            }
            else
            {
                MessageBox.Show("Solo se permiten Numeros");
                e.Handled = true;
            }


        }

        public void valida_Celular(object sender, TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            count = Controlestudiante.celular_leng();
            if (character >= 48 && character <= 57 && count != 9)
            {
                if (count <= 7)
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Los numeros de telefono constan de 8 digitos");
                    e.Handled = true;
                }

            }
            else
            {
                MessageBox.Show("Solo se permiten Numeros");
                e.Handled = true;
            }
        }
    }
}
