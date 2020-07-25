using System.Threading.Tasks;
using Abp.Application.Services;
using AdsTest.Sessions.Dto;

namespace AdsTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
