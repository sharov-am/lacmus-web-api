using System.Threading.Tasks;
using Abp.Application.Services;
using lacmus.WebApp.Sessions.Dto;

namespace lacmus.WebApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
