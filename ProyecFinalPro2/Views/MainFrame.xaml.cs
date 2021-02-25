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
        private UserControl_Configuracion confi;
        private MainController MC;
        private bool v;


        public MainFrame(bool v)
        {
            InitializeComponent();
            this.v = v;
            AddItemMainFrame();
            SeputControllers();
        }

        private void AddItemMainFrame()
        {
            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("New registration","Nueva Matricula",PackIconKind.Create, new UserControlStudent()));
            menuRegister.Add(new SubItem("Registry","Registros de Matriculas",PackIconKind.Database, new UserControl_BD_Student()));
            ItemMenu item1 = new ItemMenu("Student", menuRegister, PackIconKind.Register);


            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Add","Agregar Usuarios",PackIconKind.UserTick, new UserControlViewModel()));
            ItemMenu item2 = new ItemMenu("Admin", menuReports, PackIconKind.FileReport);

            
            
            MenuItem.Children.Add(new UserControlMenuItem(item1, this));

            if (v){MenuItem.Children.Add(new UserControlMenuItem(item2, this));}

            confi = new UserControl_Configuracion();
            

        }
        //-----------------------------------------------------------------------------------------------------------------

        public void SwitchScreen(UserControl screen)
        {
            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                
                StackPanelMain.Children.Add(screen);
            }
            else{MessageBox.Show("Erro no se pudo cargar la ventana");}
        }

        public void SeputControllers()
        {
            MC = new MainController(this);
            this.ButtonMax.Click += new RoutedEventHandler(MC.ButtonHandler);
            this.ButtonExit.Click += new RoutedEventHandler(MC.ButtonHandler);
            this.ButtonMin.Click += new RoutedEventHandler(MC.ButtonHandler);
            this.BarraSuperior.MouseDown += new MouseButtonEventHandler(MC.DragMoveWindows); ;
        }


        

        private void Configuracion_Click(object sender, RoutedEventArgs e)
        {
            SwitchScreen(confi);
            
        }
    }
}
