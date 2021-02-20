﻿using ProyecFinalPro2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProyecFinalPro2.Interfaz;
using ProyecFinalPro2.Controller;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyecFinalPro2.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControlStudent : UserControl, IGestionWPF
    {
        //String path = @"C:\Users\Mauro\Desktop\Proyectos de C#";

       
        private FileInfo Info;
        private Student Set_Estudiante;
        public UserControlStudent(FileInfo info)
        {
            InitializeComponent();
            this.Info = info;
            Open();
            setAll();

            SeputControllers();
            bool_Deparmento(false);
            bool_Municipio(false);
            TituloBlock.Text = Student.Title();
            FechaBlock.Text = Student.Day() + "-" + Student.Moth() + "-" + Student.Year();
        }
        public UserControlStudent()
        {
            InitializeComponent();
            SeputControllers();
            bool_Deparmento(false);
            bool_Municipio(false);
            TituloBlock.Text = Student.Title();
            FechaBlock.Text = Student.Day() + "-" + Student.Moth() + "-" + Student.Year();
            
        }
        private void Open()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream(Info.FullName, FileMode.Open, FileAccess.Read, FileShare.None);
            Set_Estudiante = (Student)formateador.Deserialize(miStream);
            miStream.Close();
        }

        public void SeputControllers()
        {
            StudentController EstControl = new StudentController(this);
            guardar.Click += new RoutedEventHandler(EstControl.Guardar);
            ComboNacional.SelectionChanged += new SelectionChangedEventHandler(EstControl.Nacional_SelectionChanged);
            ComboDepart.SelectionChanged += new SelectionChangedEventHandler(EstControl.Departamento_SelectionChanged);
            ComboCuatrimestres.SelectionChanged += new SelectionChangedEventHandler(EstControl.ComboCuatrimestres_SelectionChanged);
            Mandar.Click += new RoutedEventHandler(EstControl.ListBoxButtons_Click);
            Mandar_Todo.Click += new RoutedEventHandler(EstControl.ListBoxButtons_Click);
            Remove.Click += new RoutedEventHandler(EstControl.ListBoxButtons_Click);
            RemoveAll.Click += new RoutedEventHandler(EstControl.ListBoxButtons_Click);
        }

        public List<Student> getestudiantes() 
        {
            Student Estudiante = new Student();
            List<Student> est = new List<Student>();
            Estudiante.CarnetBox = CarnetBox.Text;
            Estudiante.NyABox = Nom_ApBox.Text;
            est.Add(Estudiante);
            return est;
        }

        public Student getAll() 
        {
            Student Estudiante = new Student();
            Estudiante.GrupBox = CarnetBox.Text;
            Estudiante.ComboTurno = Convert.ToInt32(ComboTurno.SelectedIndex);
            Estudiante.NyABox = Nom_ApBox.Text;
            Estudiante.CarnetBox = CarnetBox.Text;
            Estudiante.SolteroRadio = SolteroRadio.IsChecked;
            Estudiante.CasadoRadio = CasadoRadio.IsChecked;
            Estudiante.MRadio = MRadio.IsChecked;
            Estudiante.FRadio = FRadio.IsChecked;
            Estudiante.LyFBox = LyFBox.Text;
            Estudiante.AgeBox = AgeBox.Text;
            Estudiante.ComboNacional = Convert.ToInt32(ComboNacional.SelectedIndex);
            Estudiante.ComboDepart = Convert.ToInt32(ComboDepart.SelectedIndex);
            Estudiante.ComboMuni = Convert.ToInt32(ComboMuni.SelectedIndex);
            Estudiante.DirectBox = DirectionBox.Text;
            Estudiante.TelfBox = Phonebox.Text;
            Estudiante.CelBox = Cel_box.Text;
            Estudiante.CentroBox = CentroBox.Text;
            Estudiante.EstaRadio = EstaRadio.IsChecked;
            Estudiante.PrivRadio = PrivRadio.IsChecked;
            Estudiante.SubvRadio = SubRadio.IsChecked;
            Estudiante.OrdiRadio = OrdiRadio.IsChecked;
            Estudiante.BecRadio = BecRadio.IsChecked;
            Estudiante.TrabRadio = TrabRadio.IsChecked;
            Estudiante.TrabajaSRadio = TrabSRadio.IsChecked;
            Estudiante.TrabajaNRadio = TrabNRadio.IsChecked;
            Estudiante.NIngrRadio = IngrRadio.IsChecked;
            Estudiante.ReingreRadio = ReingrRadio.IsChecked;
            Estudiante.TrasIntRadio = TrasIntRadio.IsChecked;
            Estudiante.TrasExteRadio = TrasExRadio.IsChecked;
            Estudiante.ContCarrRadio = ContiRadio.IsChecked;
            Estudiante.SegCarrRadio = SegRadio.IsChecked;
            return Estudiante;    
        }

        public void setAll()
        {
            Nom_ApBox.Text = Set_Estudiante.NyABox;
            CarnetBox.Text = Set_Estudiante.CarnetBox;
            
        }

        public void item_Departamento(string d) {ComboDepart.Items.Add(d);}

        public void item_Municipio(string m) {ComboMuni.Items.Add(m);}

        public void bool_Deparmento(bool d) { ComboDepart.IsEnabled = d;}

        public void bool_Municipio(bool m) { ComboMuni.IsEnabled = m;}

        public string Obtener_Nacionalidad() { return ComboNacional.SelectedIndex.ToString(); }

        public int Obtener_Departamento() { return ComboDepart.SelectedIndex; }

        public void limpiar_Departamento() { ComboDepart.Items.Clear(); }

        public void limpiar_Municipio() { ComboMuni.Items.Clear(); }

        public string mandar_carnet() {return CarnetBox.Text;}

        public string mandar_fecha() {return FechaBlock.Text;}

        public void limpiar_Inscribir() { Inscribir.Items.Clear(); }

        public void limpiar_Inscrito() { Inscrito.Items.Clear();}

        public bool contenedor_Inscrito(string u) { return Inscrito.Items.Contains(u); }

        public void agregar_Inscribir(string u) { Inscribir.Items.Add(u); }

        public void agregar_Inscrito(string u) { Inscrito.Items.Add(u); }

        public int select_ComboCuatrimestre() { return ComboCuatrimestres.SelectedIndex; }

        public void selected_Inscribir() {  Inscribir.Items.Add(Inscrito.SelectedItem); }

        public void selected_Inscrito() { Inscrito.Items.Add(Inscribir.SelectedItem); remove_Inscribir(); }

        public void remove_Inscribir() { Inscribir.Items.Remove(Inscribir.SelectedItem); }  

        public void remove_Inscrito() { Inscrito.Items.Remove(Inscrito.SelectedItem); }

        public void actulizar_Inscribir() { Inscribir.Items.Refresh();}

        public bool prueba() { return Inscribir.SelectedItem.Equals(""); }

        public ItemCollection items_Inscribir() {  return Inscribir.Items; }

        public int contador_Incrito() { return Inscrito.Items.Count; }

    }
}
