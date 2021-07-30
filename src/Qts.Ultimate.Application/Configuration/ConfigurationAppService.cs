﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Qts.Ultimate.Configuration.Dto;

namespace Qts.Ultimate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UltimateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
