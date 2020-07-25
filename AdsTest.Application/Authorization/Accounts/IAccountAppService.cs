using System.Threading.Tasks;
using Abp.Application.Services;
using AdsTest.Authorization.Accounts.Dto;

namespace AdsTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
