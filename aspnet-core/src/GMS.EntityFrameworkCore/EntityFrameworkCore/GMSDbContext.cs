using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GMS.Authorization.Roles;
using GMS.Authorization.Users;
using GMS.MultiTenancy;

namespace GMS.EntityFrameworkCore
{
    public class GMSDbContext : AbpZeroDbContext<Tenant, Role, User, GMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GMSDbContext(DbContextOptions<GMSDbContext> options)
            : base(options)
        {
        }
    }
}
