using Abp.Authorization;
using Qts.Ultimate.Authorization.Roles;
using Qts.Ultimate.Authorization.Users;

namespace Qts.Ultimate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
