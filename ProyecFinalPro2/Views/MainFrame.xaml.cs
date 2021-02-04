using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
using ProyecFinalPro2.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyecFinalPro2.Views
{
    /// <summary>
    /// Lógica de interacción para MainFrame.xaml
    /// </summary>
    public partial class MainFrame : Window
    {
    
        public MainFrame()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Update"));
            menuRegister.Add(new SubItem("Add"));
            menuRegister.Add(new SubItem("BD-Student"));
            var item6 = new ItemMenu("Student", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
         
            
            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Agregar"));
            menuReports.Add(new SubItem("Eliminar"));
            menuReports.Add(new SubItem("Actualizar"));
            var item2 = new ItemMenu("Admin", menuReports, PackIconKind.FileReport);



            var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.ViewDashboard);

            Menu.Children.Add(new UserControlMenuItem(item0));
            Menu.Children.Add(new UserControlMenuItem(item6));
            Menu.Children.Add(new UserControlMenuItem(item2));

        }

        
        


    }
}
