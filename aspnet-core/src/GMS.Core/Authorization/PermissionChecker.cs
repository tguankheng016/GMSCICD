using Abp.Authorization;
using GMS.Authorization.Roles;
using GMS.Authorization.Users;

namespace GMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
