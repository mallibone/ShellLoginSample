using ShellLogin.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellLogin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("registration", typeof(RegistrationPage));
        }
    }
}
