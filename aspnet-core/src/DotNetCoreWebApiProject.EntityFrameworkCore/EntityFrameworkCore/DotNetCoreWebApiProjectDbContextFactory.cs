using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DotNetCoreWebApiProject.Configuration;
using DotNetCoreWebApiProject.Web;

namespace DotNetCoreWebApiProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DotNetCoreWebApiProjectDbContextFactory : IDesignTimeDbContextFactory<DotNetCoreWebApiProjectDbContext>
    {
        public DotNetCoreWebApiProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DotNetCoreWebApiProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DotNetCoreWebApiProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DotNetCoreWebApiProjectConsts.ConnectionStringName));

            return new DotNetCoreWebApiProjectDbContext(builder.Options);
        }
    }
}
