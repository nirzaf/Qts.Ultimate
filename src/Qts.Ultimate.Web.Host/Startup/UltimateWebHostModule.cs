using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Qts.Ultimate.Configuration;

namespace Qts.Ultimate.Web.Host.Startup
{
    [DependsOn(
       typeof(UltimateWebCoreModule))]
    public class UltimateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UltimateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UltimateWebHostModule).GetAssembly());
        }
    }
}
