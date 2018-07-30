using Abp.Authorization;
using DotNetCoreWebApiProject.Authorization.Roles;
using DotNetCoreWebApiProject.Authorization.Users;

namespace DotNetCoreWebApiProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
