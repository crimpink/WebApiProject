using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebApiProject.EntityFrameworkCore
{
    public static class DotNetCoreWebApiProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DotNetCoreWebApiProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DotNetCoreWebApiProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
