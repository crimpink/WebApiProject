using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DotNetCoreWebApiProject.Configuration.Dto;

namespace DotNetCoreWebApiProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DotNetCoreWebApiProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
