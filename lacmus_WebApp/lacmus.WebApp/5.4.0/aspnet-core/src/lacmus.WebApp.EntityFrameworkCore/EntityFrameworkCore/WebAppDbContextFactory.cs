using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using lacmus.WebApp.Configuration;
using lacmus.WebApp.Web;

namespace lacmus.WebApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WebAppDbContextFactory : IDesignTimeDbContextFactory<WebAppDbContext>
    {
        public WebAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WebAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WebAppConsts.ConnectionStringName));

            return new WebAppDbContext(builder.Options);
        }
    }
}
