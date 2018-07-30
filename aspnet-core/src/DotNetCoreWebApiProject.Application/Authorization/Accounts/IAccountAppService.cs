using System.Threading.Tasks;
using Abp.Application.Services;
using DotNetCoreWebApiProject.Authorization.Accounts.Dto;

namespace DotNetCoreWebApiProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
