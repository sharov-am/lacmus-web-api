using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using lacmus.WebApp.Configuration;

namespace lacmus.WebApp.Web.Host.Startup
{
    [DependsOn(
       typeof(WebAppWebCoreModule))]
    public class WebAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WebAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebAppWebHostModule).GetAssembly());
        }
    }
}
