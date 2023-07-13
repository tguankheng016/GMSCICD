using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GMS.Controllers
{
    public abstract class GMSControllerBase: AbpController
    {
        protected GMSControllerBase()
        {
            LocalizationSourceName = GMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
