using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DotNetCoreWebApiProject.Controllers
{
    public abstract class DotNetCoreWebApiProjectControllerBase: AbpController
    {
        protected DotNetCoreWebApiProjectControllerBase()
        {
            LocalizationSourceName = DotNetCoreWebApiProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
