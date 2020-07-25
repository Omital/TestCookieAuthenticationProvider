using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AdsTest.MultiTenancy.Dto;

namespace AdsTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
