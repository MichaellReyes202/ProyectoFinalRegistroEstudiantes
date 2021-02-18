using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
using ProyecFinalPro2.ViewModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ProyecFinalPro2.Controller;
using ProyecFinalPro2.Interfaz;

namespace ProyecFinalPro2.Views
{
    public partial class MainFrame : Window, IGestionWPF
    {
        private MainController MC;
        public MainFrame()
        {
            InitializeComponent();
            AddItemMainFrame();
            SeputControllers();
        }

        private void AddItemMainFrame()
        {

            var menuRegister = new List<SubItem>();


            menuRegister.Add(new SubItem("New registration", new UserControlStudent()));
            menuRegister.Add(new SubItem("Registry", new UserControl_BD_Student()));

            var item6 = new ItemMenu("  Student", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
            var menuReports = new List<SubItem>();


            menuReports.Add(new SubItem(" Add", new UserControlUsuario()));
            menuReports.Add(new SubItem(" Delete"));
            menuReports.Add(new SubItem(" Update"));
            var item2 = new ItemMenu("  Admin", menuReports, PackIconKind.FileReport);




            var item0 = new ItemMenu(" Opciones", new UserControl(), PackIconKind.ViewDashboard);

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


        public void SeputControllers()
        {
            MC = new MainController(this);
            this.ButtonMin.Click += new RoutedEventHandler(MC.ButtonHandler);
            this.ButtonExit.Click += new RoutedEventHandler(MC.ButtonHandler);
            this.BarraSuperior.MouseDown += new MouseButtonEventHandler(MC.DragMoveWindows); ;
        }


    }
}
