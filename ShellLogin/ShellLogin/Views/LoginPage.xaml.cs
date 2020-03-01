using ShellLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = ViewModel;
		}

	    internal LoginViewModel ViewModel { get; set; } = new LoginViewModel(App.NavigationService);
    }
}