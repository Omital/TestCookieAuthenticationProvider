using Abp.Authorization;
using AdsTest.Authorization.Roles;
using AdsTest.Authorization.Users;

namespace AdsTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
