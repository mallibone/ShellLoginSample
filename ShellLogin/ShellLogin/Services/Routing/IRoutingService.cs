using System.Threading.Tasks;

namespace ShellLogin.Services.Routing
{
    public interface IRoutingService
    {
        Task GoBack();
        Task GoBackModal();
        Task NavigateTo(string route);
    }
}
