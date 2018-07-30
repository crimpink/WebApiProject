using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DotNetCoreWebApiProject.MultiTenancy.Dto;

namespace DotNetCoreWebApiProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
