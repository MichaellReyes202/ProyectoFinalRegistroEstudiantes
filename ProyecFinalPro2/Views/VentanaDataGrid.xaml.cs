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
using System.Windows.Shapes;

namespace ProyecFinalPro2.Views
{
    /// <summary>
    /// Lógica de interacción para VentanaDataGrid.xaml
    /// </summary>
    public partial class VentanaDataGrid : Window
    {
        public VentanaDataGrid(FileInfo info)
        {
            InitializeComponent();

            StackPanelMain.Children.Add(new UserControlStudent(info) );
        }
    }
}
