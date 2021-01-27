using System.Threading.Tasks;
using RestSharp;

namespace KabloomClient.Models
{
  public class ApiHelper
  {
    // public static async Task<string> ApiCall()
    // {
    //   RestClient client = new RestClient($"https://trefle.io/api/v1/plants?token={KabloomTrefleApi.Models.EnvironmentVariables.ApiKey}");
    //   RestRequest request = new RestRequest(Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }
    public static async Task<string> GetLocation()
    {
      RestClient client = new RestClient("http://localhost:5000/api/locations");
      RestRequest request = new RestRequest($"Seattle, WA", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    // public static async Task Post(string newDestination)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"destinations", Method.POST);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newDestination);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Put(int id, string newDestination)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"destinations/{id}", Method.PUT);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newDestination);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Delete(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"destinations/{id}", Method.DELETE);
    //   request.AddHeader("Content-Type", "application/json");
    //   var response = await client.ExecuteTaskAsync(request);
    // }
  public static async Task<string> FourSquareCall()
    {
      string url = "https://api.foursquare.com/v2/venues/";
      string clientId = $"client_id={EnvironmentVariables.FourSquareId}";
      string clientSecret = $"&client_secret={EnvironmentVariables.FourSquareSecret}";
      string versionByDate = "&v=20210125";
      // string nearLocation = $"&near={searchLocation}";
      string nearLocation = $"&near=Vancouver, WA";
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