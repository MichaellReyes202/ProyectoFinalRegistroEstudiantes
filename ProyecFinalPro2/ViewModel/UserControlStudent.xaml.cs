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

namespace ProyecFinalPro2.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControlStudent : UserControl
    {
        //String path = @"C:\Users\Mauro\Desktop\Proyectos de C#";
        

        public UserControlStudent()
        {
            InitializeComponent();
            SetupController();
            TituloBlock.Text = Student.Title();
            FechaBlock.Text = Student.Day() + "/" + Student.Moth() + "/" + Student.Year();
            
        }


        public void SetupController() 
        {
            
        
        }

        public void Guardar()
        {
            /*
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

            try
            {
                StreamWriter streamWriter = new StreamWriter(path + Nom_ApBox.Text, true);

                streamWriter.WriteLine(CarnetBox.Text+"," + Nom_ApBox.Text + "," + LyFBox.Text);
                
                streamWriter.Flush(); streamWriter.Close();

            }
            catch (Exception x) { MessageBox.Show("Errro Archvio Write"); }
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"RegistroEstudiantes\"+CarnetBox.Text;
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

        }



        
    }
}
