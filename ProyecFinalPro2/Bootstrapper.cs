using Caliburn.Micro;
using ProyecFinalPro2.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ProyecFinalPro2
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<UserControl_BD_Student>();
        }

    }
}
