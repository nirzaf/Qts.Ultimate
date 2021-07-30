using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Qts.Ultimate.Controllers
{
    public abstract class UltimateControllerBase: AbpController
    {
        protected UltimateControllerBase()
        {
            LocalizationSourceName = UltimateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
