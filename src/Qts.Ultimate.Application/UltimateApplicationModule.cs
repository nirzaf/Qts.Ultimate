using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Qts.Ultimate.Authorization;

namespace Qts.Ultimate
{
    [DependsOn(
        typeof(UltimateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UltimateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UltimateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UltimateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
