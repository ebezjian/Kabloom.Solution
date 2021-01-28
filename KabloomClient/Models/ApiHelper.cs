using System.Threading.Tasks;
using RestSharp;

namespace KabloomClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient($"https://trefle.io/api/v1/");
      RestRequest request = new RestRequest($"plants?token={EnvironmentVariables.ApiKey}&filter=[vegetable]=true", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetPlants(string searchString)
    {
      // client: https://trefle.io/api/v1/
      // request for SEARCH BY NAME: plants?token={EnvironmentVariables.ApiKey}&filter[common_name]={SearchString}
      // request for SPECIFIC PLANT BY #ID: species/{id}?token={EnvironmentVariables.ApiKey}
      RestClient client = new RestClient($"https://trefle.io/api/v1/");
      RestRequest request = new RestRequest($"plants?token={EnvironmentVariables.ApiKey}&filter[common_name]={searchString}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;

    }
    public static async Task<string> FourSquareCall(string searchLocation)
    {
      string url = "https://api.foursquare.com/v2/venues/";
      string clientId = $"client_id={EnvironmentVariables.FourSquareId}";
      string clientSecret = $"&client_secret={EnvironmentVariables.FourSquareSecret}";
      string versionByDate = "&v=20210125";
      string nearLocation = $"&near={searchLocation}";
      // string nearLocation = $"&near=Vancouver, WA";
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