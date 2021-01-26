using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace KabloomClient.Models
{
    public class KabloomClientContextFactory : IDesignTimeDbContextFactory<KabloomClientContext>
    {
        KabloomClientContext IDesignTimeDbContextFactory<KabloomClientContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<KabloomClientContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new KabloomClientContext(builder.Options);
        }
    }
}