using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace BeautySolutions.View.ViewModel
{
    public class SubItem
    {
        //public SubItem(string name, UserControl screen = null)
        //public SubItem(string name, UserControl screen)
        public SubItem(string name,string tip, PackIconKind icon, UserControl user)
        {
            Name = name;
            Screen = user;
            this.tip = tip;
            Icono = icon;
        }
       

        public string Name { get; private set; }
        public UserControl Screen { get; private set; }
        public PackIconKind Icono { get; private set; }
        public string tip { get; private set; }
    }
}