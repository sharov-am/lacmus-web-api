using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using lacmus.WebApp.Roles.Dto;
using lacmus.WebApp.Users.Dto;

namespace lacmus.WebApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
