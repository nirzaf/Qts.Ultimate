using System.Threading.Tasks;
using Qts.Ultimate.Configuration.Dto;

namespace Qts.Ultimate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
