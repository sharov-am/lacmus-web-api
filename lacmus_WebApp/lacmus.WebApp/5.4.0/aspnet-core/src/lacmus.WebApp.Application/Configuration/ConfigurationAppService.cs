using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using lacmus.WebApp.Configuration.Dto;

namespace lacmus.WebApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
