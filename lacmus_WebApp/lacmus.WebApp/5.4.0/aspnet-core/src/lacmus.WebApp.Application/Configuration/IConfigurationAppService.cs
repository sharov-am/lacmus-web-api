using System.Threading.Tasks;
using lacmus.WebApp.Configuration.Dto;

namespace lacmus.WebApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
