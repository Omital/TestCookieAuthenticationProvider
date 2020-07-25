using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AdsTest.Roles.Dto;
using AdsTest.Users.Dto;

namespace AdsTest.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}