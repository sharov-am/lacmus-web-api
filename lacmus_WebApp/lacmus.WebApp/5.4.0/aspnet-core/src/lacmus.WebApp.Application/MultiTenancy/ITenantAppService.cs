using Abp.Application.Services;
using lacmus.WebApp.MultiTenancy.Dto;

namespace lacmus.WebApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

