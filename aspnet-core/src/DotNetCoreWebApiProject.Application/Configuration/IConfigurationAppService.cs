using System.Threading.Tasks;
using DotNetCoreWebApiProject.Configuration.Dto;

namespace DotNetCoreWebApiProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
