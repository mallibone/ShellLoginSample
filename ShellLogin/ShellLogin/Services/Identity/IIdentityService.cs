using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShellLogin.Services.Identity
{

    interface IIdentityService
    {
        Task<bool> VerifyRegistration();
        Task Authenticate();
    }
}
