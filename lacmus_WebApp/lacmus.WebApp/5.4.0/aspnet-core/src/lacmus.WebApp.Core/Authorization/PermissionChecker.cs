using Abp.Authorization;
using lacmus.WebApp.Authorization.Roles;
using lacmus.WebApp.Authorization.Users;

namespace lacmus.WebApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
