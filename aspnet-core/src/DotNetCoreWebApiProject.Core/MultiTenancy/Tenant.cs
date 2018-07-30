﻿using Abp.MultiTenancy;
using DotNetCoreWebApiProject.Authorization.Users;

namespace DotNetCoreWebApiProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
