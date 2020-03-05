using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellLogin.Views;
using ShellLogin.Services.Routing;
using Splat;
using ShellLogin.Services.Identity;
using ShellLogin.ViewModels;

namespace ShellLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeDi();
            InitializeComponent();

            MainPage = new AppShell();
        }

        private void InitializeDi()
        {
            // Services
            Locator.CurrentMutable.RegisterLazySingleton<IRoutingService>(() => new ShellRoutingService());
            Locator.CurrentMutable.RegisterLazySingleton<IIdentityService>(() => new IdentityServiceStub());

            // ViewModels
            Locator.CurrentMutable.Register(() => new LoadingViewModel());
            Locator.CurrentMutable.Register(() => new LoginViewModel());
            Locator.CurrentMutable.Register(() => new RegistrationViewModel());
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
