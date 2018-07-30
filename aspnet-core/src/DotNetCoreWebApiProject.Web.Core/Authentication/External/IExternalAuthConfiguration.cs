using System.Collections.Generic;

namespace DotNetCoreWebApiProject.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
