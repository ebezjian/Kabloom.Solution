using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KabloomApi
{
  public class Plant
  {
    public int Id { get; set; }
    public string Common_name { get; set; }
    public string image_url { get; set; }

    public static List<Plant> GetPlants(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["results"].ToString());

      return plantList;
    }
  }
}