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
using ProyecFinalPro2.Controller;

namespace ProyecFinalPro2.Views
{
    public partial class MainFrame : Window
    {
        public MainFrame()
        {
            InitializeComponent();
            AddItemMainFrame();
        }

        private void AddItemMainFrame()
        {
            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Update", new UserControlUpdateStudent() ));
            menuRegister.Add(new SubItem("Add",new UserControlAddEstudent() ));
            menuRegister.Add(new SubItem("BD-Student"));
            var item6 = new ItemMenu("Student", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Add"));
            menuReports.Add(new SubItem("Delete"));
            menuReports.Add(new SubItem("Update"));
            var item2 = new ItemMenu("Admin", menuReports, PackIconKind.FileReport);

            var item0 = new ItemMenu("Opciones", new UserControl(), PackIconKind.ViewDashboard);

            MenuItem.Children.Add(new UserControlMenuItem(item0, this));
            MenuItem.Children.Add(new UserControlMenuItem(item6, this));
            MenuItem.Children.Add(new UserControlMenuItem(item2, this));
        }
        //-----------------------------------------------------------------------------------------------------------------
        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);
            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonMinimizar_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }

        }
    }
}
