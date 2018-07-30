using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DotNetCoreWebApiProject.Authorization.Roles;
using DotNetCoreWebApiProject.Authorization.Users;
using DotNetCoreWebApiProject.MultiTenancy;

namespace DotNetCoreWebApiProject.EntityFrameworkCore
{
    public class DotNetCoreWebApiProjectDbContext : AbpZeroDbContext<Tenant, Role, User, DotNetCoreWebApiProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DotNetCoreWebApiProjectDbContext(DbContextOptions<DotNetCoreWebApiProjectDbContext> options)
            : base(options)
        {
        }
    }
}
