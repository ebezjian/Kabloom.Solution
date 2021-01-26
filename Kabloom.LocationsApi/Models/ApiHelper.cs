using System.Threading.Tasks;
using RestSharp;
using System;

namespace KabloomLocationsApi.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      string url = "https://api.foursquare.com/v2/venues/";
      string clientId = $"client_id={EnvironmentVariables.ClientId}";
      string clientSecret = $"&client_secret={EnvironmentVariables.ClientSecret}";
      string versionByDate = "&v=20210125";
      // string nearLocation = $"&near={Search}";
      string nearLocation = $"&near=Portland, OR";
      string intent = "&intent=browse";
      string radius = "&radius=10000";
      string limit = "&limit=5";
      string categoryId = "&categoryId=4eb1c0253b7b52c0e1adc2e9";

      RestClient client = new RestClient(url);
      RestRequest request = new RestRequest(
      (
        "search?" + clientId + clientSecret + versionByDate + nearLocation + intent + radius + limit + categoryId
      ), Method.GET);

      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
  }
}