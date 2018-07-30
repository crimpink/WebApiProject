using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using DotNetCoreWebApiProject.Authorization.Roles;
using DotNetCoreWebApiProject.Authorization.Users;
using DotNetCoreWebApiProject.Configuration;
using DotNetCoreWebApiProject.Localization;
using DotNetCoreWebApiProject.MultiTenancy;
using DotNetCoreWebApiProject.Timing;

namespace DotNetCoreWebApiProject
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class DotNetCoreWebApiProjectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            DotNetCoreWebApiProjectLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = DotNetCoreWebApiProjectConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DotNetCoreWebApiProjectCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
