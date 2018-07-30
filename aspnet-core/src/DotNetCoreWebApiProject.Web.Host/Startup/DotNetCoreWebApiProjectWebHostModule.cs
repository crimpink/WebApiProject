using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotNetCoreWebApiProject.Configuration;

namespace DotNetCoreWebApiProject.Web.Host.Startup
{
    [DependsOn(
       typeof(DotNetCoreWebApiProjectWebCoreModule))]
    public class DotNetCoreWebApiProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DotNetCoreWebApiProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DotNetCoreWebApiProjectWebHostModule).GetAssembly());
        }
    }
}
