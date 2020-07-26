using Abp.Dependency;
using System.Linq;
using System.Security.Claims;
using System.Threading;

namespace AdsTest
{
    public class AdsSession: ITransientDependency
    {
        public string SubsystemId
        {
            get
            {
                var claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
                if (claimsPrincipal == null)
                {
                    return null;
                }


                var emailClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "SubsystemId");
                if (emailClaim == null || string.IsNullOrEmpty(emailClaim.Value))
                {
                    return null;
                }

                return emailClaim.Value;
            }
        }

    }
}
