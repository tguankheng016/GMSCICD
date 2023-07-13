using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GMS.Authorization;

namespace GMS
{
    [DependsOn(
        typeof(GMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
