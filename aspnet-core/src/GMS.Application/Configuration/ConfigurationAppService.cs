using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GMS.Configuration.Dto;

namespace GMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
