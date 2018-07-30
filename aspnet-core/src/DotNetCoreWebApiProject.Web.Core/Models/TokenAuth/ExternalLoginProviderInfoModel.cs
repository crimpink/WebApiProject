using Abp.AutoMapper;
using DotNetCoreWebApiProject.Authentication.External;

namespace DotNetCoreWebApiProject.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
