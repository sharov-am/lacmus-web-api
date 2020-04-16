using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace lacmus.WebApp.EntityFrameworkCore
{
    public static class WebAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebAppDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebAppDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
