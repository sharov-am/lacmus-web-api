using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using lacmus.WebApp.Authorization.Roles;
using lacmus.WebApp.Authorization.Users;
using lacmus.WebApp.MultiTenancy;

namespace lacmus.WebApp.EntityFrameworkCore
{
    public class WebAppDbContext : AbpZeroDbContext<Tenant, Role, User, WebAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options)
            : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LA;Username=lacmus_test;Password=asddsa");
        }

    }
}
