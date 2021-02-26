using BeautySolutions.View.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using ProyecFinalPro2.Views;

namespace ProyecFinalPro2.ViewModel
{
    public partial class UserControlMenuItem : UserControl
    {
        MainFrame _context;
        public UserControlMenuItem(ItemMenu itemMenu, MainFrame context)
        {
            _context = context;
            InitializeComponent();
            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;
            DataContext = itemMenu;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SubItem sub = ((SubItem)((ListBox)sender).SelectedItem);
            try
            {
                _context.SwitchScreen(sub.Screen);
                this.ListViewMenu.SelectedIndex = -1;
            }
            catch (Exception){}

        }
    }
}
