using System.Threading.Tasks;
using GMS.Configuration.Dto;

namespace GMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
