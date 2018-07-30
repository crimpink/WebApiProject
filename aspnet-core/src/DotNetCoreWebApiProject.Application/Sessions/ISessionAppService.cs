using System.Threading.Tasks;
using Abp.Application.Services;
using DotNetCoreWebApiProject.Sessions.Dto;

namespace DotNetCoreWebApiProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
