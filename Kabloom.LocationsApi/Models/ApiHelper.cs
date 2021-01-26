using System.Threading.Tasks;
using RestSharp;
using System;

namespace KabloomLocationsApi.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("https://api.foursquare.com/v2/venues/");
      RestRequest request = new RestRequest($"search?client_id={EnvironmentVariables.ClientId}&client_secret={EnvironmentVariables.ClientSecret}&v=20210125&near=PORTLAND, OR&intent=browse&radius=10000&limit=1&categoryId=4eb1c0253b7b52c0e1adc2e9", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}