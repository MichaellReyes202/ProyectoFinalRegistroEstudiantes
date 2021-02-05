using System;
using System.Collections.Generic;
using System.Text;
using ProyecFinalPro2.Views;
using ProyecFinalPro2.Interfaz;

namespace ProyecFinalPro2.Controller
{
     public class LoginController
     {
          private LoginViews loginViews;

          public LoginController(LoginViews loginViews) {
               this.loginViews = loginViews;
          }
     }
}
