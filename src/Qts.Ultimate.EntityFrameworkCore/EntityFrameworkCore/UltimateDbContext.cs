using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Qts.Ultimate.Authorization.Roles;
using Qts.Ultimate.Authorization.Users;
using Qts.Ultimate.MultiTenancy;

namespace Qts.Ultimate.EntityFrameworkCore
{
    public class UltimateDbContext : AbpZeroDbContext<Tenant, Role, User, UltimateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public UltimateDbContext(DbContextOptions<UltimateDbContext> options)
            : base(options)
        {
        }
    }
}
