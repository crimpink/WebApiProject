using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotNetCoreWebApiProject.Configuration;
using DotNetCoreWebApiProject.EntityFrameworkCore;
using DotNetCoreWebApiProject.Migrator.DependencyInjection;

namespace DotNetCoreWebApiProject.Migrator
{
    [DependsOn(typeof(DotNetCoreWebApiProjectEntityFrameworkModule))]
    public class DotNetCoreWebApiProjectMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DotNetCoreWebApiProjectMigratorModule(DotNetCoreWebApiProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(DotNetCoreWebApiProjectMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                DotNetCoreWebApiProjectConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DotNetCoreWebApiProjectMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
