using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Qts.Ultimate.EntityFrameworkCore
{
    public static class UltimateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UltimateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UltimateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
