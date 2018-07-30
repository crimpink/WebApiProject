using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotNetCoreWebApiProject.Authorization;

namespace DotNetCoreWebApiProject
{
    [DependsOn(
        typeof(DotNetCoreWebApiProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DotNetCoreWebApiProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DotNetCoreWebApiProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DotNetCoreWebApiProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
