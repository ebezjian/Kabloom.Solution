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
using KabloomApi.Models;

namespace KabloomApi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var apiCallTask = ApiHelper.ApiCall("[JZzbz5ld2jLv7RU-HDGVfgPHGH-MPKVMjaVDUowBO1w]");
            var result = apiCallTask.Result;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["results"].ToString());
            // return result;
        }
    }
    class ApiHelper
    {
        public static async Task<string>ApiCall(string apiKey)
        {
            RestClient client = new RestClient ("https://trefle.io/api/v1");
            RestRequest request = new RestRequest($"home.json?api-key={EnvironmentVariables.ApiKey}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}






    // {
    //     public static void Main(string[] args)
    //     {
    //         CreateWebHostBuilder(args).Build().Run();
    //     }

    //     public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    //         WebHost.CreateDefaultBuilder(args)
    //             .UseStartup<Startup>();