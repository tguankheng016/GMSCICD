using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GMS.EntityFrameworkCore
{
    public static class GMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
