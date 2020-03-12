using ShellLogin.Services.Identity;
using ShellLogin.Services.Routing;
using Splat;

namespace ShellLogin.ViewModels
{
    class LoadingViewModel : BaseViewModel
    {
        private readonly IRoutingService routingService;
        private readonly IIdentityService identityService;

        public LoadingViewModel(IRoutingService routingService = null, IIdentityService identityService = null)
        {
            this.routingService = routingService ?? Locator.Current.GetService<IRoutingService>();
            this.identityService = identityService ?? Locator.Current.GetService<IIdentityService>();
        }

        // Called by the views OnAppearing method
        public async void Init()
        {
            var isAuthenticated = await this.identityService.VerifyRegistration();
            if (isAuthenticated)
            {
                await this.routingService.NavigateTo("///main");
            }
            else
            {
                await this.routingService.NavigateTo("///login");
            }
        }
    }
}
