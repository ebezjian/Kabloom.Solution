using System.Threading.Tasks;
using RestSharp;
using System;

namespace KabloomTrefleApi.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient($"https://trefle.io/api/v1/plants?token={EnvironmentVariables.ApiKey}");
      RestRequest request = new RestRequest(Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}


