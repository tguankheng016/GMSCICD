using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GMS.EntityFrameworkCore;
using GMS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GMS.Web.Tests
{
    [DependsOn(
        typeof(GMSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GMSWebTestModule : AbpModule
    {
        public GMSWebTestModule(GMSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GMSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GMSWebMvcModule).Assembly);
        }
    }
}