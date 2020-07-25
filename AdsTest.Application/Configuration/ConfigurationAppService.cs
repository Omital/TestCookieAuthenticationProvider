using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AdsTest.Configuration.Dto;

namespace AdsTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdsTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
