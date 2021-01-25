using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using KabloomLocationsApi.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

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

      // CreateWebHostBuilder(args).Build().Run();
      // var apiCallTask = ApiHelper.ApiCall(clientId, clientSecret);
      // var result = apiCallTask.Result;
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
			// List<Location> locationList = JsonConvert.DeserializeObject<List<Location>>(jsonResponse["results"].ToString());

			// foreach (Location location in locationList)
			// {
			// 	{location.Name};
			// 	{location.Address};
			// 	{location.City};
			// 	{location.Country};
			// 	{location.FormattedAddress};
			// }
			// Console.WriteLine(jsonResponse["results"]);
    // }


		// 	}
    // }

    // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    //   WebHost.CreateDefaultBuilder(args)
    //     .UseStartup<Startup>();