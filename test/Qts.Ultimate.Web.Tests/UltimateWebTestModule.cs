using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Qts.Ultimate.EntityFrameworkCore;
using Qts.Ultimate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Qts.Ultimate.Web.Tests
{
    [DependsOn(
        typeof(UltimateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class UltimateWebTestModule : AbpModule
    {
        public UltimateWebTestModule(UltimateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UltimateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(UltimateWebMvcModule).Assembly);
        }
    }
}