using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using lacmus.WebApp.Authorization;

namespace lacmus.WebApp
{
    [DependsOn(
        typeof(WebAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WebAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
