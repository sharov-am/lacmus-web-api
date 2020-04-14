using System.Threading.Tasks;
using Abp.Application.Services;
using lacmus.WebApp.Authorization.Accounts.Dto;

namespace lacmus.WebApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
