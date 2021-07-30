using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Qts.Ultimate.Configuration;
using Qts.Ultimate.Web;

namespace Qts.Ultimate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class UltimateDbContextFactory : IDesignTimeDbContextFactory<UltimateDbContext>
    {
        public UltimateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UltimateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            UltimateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(UltimateConsts.ConnectionStringName));

            return new UltimateDbContext(builder.Options);
        }
    }
}
