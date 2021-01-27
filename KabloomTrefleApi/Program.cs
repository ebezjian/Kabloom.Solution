using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using KabloomTrefleApi.Models;

namespace KabloomTrefleApi
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






    // {
    //     public static void Main(string[] args)
    //     {
    //         CreateWebHostBuilder(args).Build().Run();
    //     }

        
    //     static void Main(string[] args)
    //     {
    //         var apiCallTask = ApiHelper.ApiCall("[EnvironmentVariables.ApiKey]");
    //         var result = apiCallTask.Result;
    //         JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //         List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["results"].ToString());
    //         CreateWebHostBuilder(args).Build().Run();
    //     }
    //     public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    //         WebHost.CreateDefaultBuilder(args)
    //             .UseStartup<Startup>();
    // }
    // public class ApiHelper
    // {
    //     public static async Task<string>ApiCall(string apiKey)
    //     {
    //         RestClient client = new RestClient ("https://trefle.io/api/v1");
    //         RestRequest request = new RestRequest($"home.json?api-key={EnvironmentVariables.ApiKey}", Method.GET);
    //         var response = await client.ExecuteTaskAsync(request);
    //         return response.Content;
    //     }