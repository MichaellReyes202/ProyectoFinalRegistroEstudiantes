using ProyecFinalPro2.Models;
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

namespace ProyecFinalPro2.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControlStudent : UserControl, IGestionWPF
    {
        //String path = @"C:\Users\Mauro\Desktop\Proyectos de C#";
       
        

        public UserControlStudent()
        {
            InitializeComponent();
            SeputControllers();
            TituloBlock.Text = Student.Title();
            FechaBlock.Text = Student.Day() + "-" + Student.Moth() + "-" + Student.Year();
            
        }

        public void SeputControllers()
        {
            StudentController EstControl = new StudentController(this);
            guardar.Click += new RoutedEventHandler(EstControl.Guardar);
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

        public string mandar_carnet() 
        {
            return CarnetBox.Text;
        }

        public string mandar_fecha() 
        {
            return FechaBlock.Text ; 
        }

    }
}
