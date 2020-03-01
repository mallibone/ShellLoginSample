using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellLogin.Views;
using ShellLogin.Services.Data;
using ShellLogin.Services.Routing;

namespace ShellLogin
{
    public partial class App : Application
    {
        public static IRoutingService NavigationService { get; } = new ShellRoutingService();

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
