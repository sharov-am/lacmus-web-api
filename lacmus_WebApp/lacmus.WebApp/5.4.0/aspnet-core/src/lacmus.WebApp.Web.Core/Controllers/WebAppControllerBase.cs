using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace lacmus.WebApp.Controllers
{
    public abstract class WebAppControllerBase: AbpController
    {
        protected WebAppControllerBase()
        {
            LocalizationSourceName = WebAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
