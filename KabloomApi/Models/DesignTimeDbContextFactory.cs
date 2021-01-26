using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace KabloomApi.Models
{
  public class KabloomApiContextFactory : IDesignTimeDbContextFactory<KabloomApiContext>
  {
    KabloomApiContext IDesignTimeDbContextFactory<KabloomApiContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<KabloomApiContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new KabloomApiContext(builder.Options);
    }
  }
}