using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellLogin.Services.Routing
{
    public class ShellRoutingService : IRoutingService
    {
        public ShellRoutingService()
        {
        }

        public Task NavigateTo(string route)
        {
            return Shell.Current.GoToAsync(route);
        }

        public Task GoBack()
        {
            return Shell.Current.Navigation.PopAsync();
        }

        public Task GoBackModal()
        {
            return Shell.Current.Navigation.PopModalAsync();
        }
    }
}
