using System.Threading.Tasks;
using Abp.Application.Services;
using AdsTest.Configuration.Dto;

namespace AdsTest.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}