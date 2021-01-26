using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using KabloomLocationsApi.Models;

namespace KabloomLocationsApi
{
  public class Program
  {
    public static void Main(string[] args)
      {
        CreateWebHostBuilder(args).Build().Run();
      }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
      WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
  }
}