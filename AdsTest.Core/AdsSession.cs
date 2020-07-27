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

                //problem is here, clm is always null
                var clm = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "SubsystemId");
                if (clm == null || string.IsNullOrEmpty(clm.Value))
                {
                    return null;
                }

                return clm.Value;
            }
        }

    }
}
