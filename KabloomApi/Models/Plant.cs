using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KabloomApi.Models
{
  public class Plant
  {
    public int Id { get; set; }
    public string Common_name { get; set; }
    public string image_url { get; set; }

    public static List<Plant> GetPlants()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      
      Console.WriteLine(jsonResponse);
      List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["data"].ToString());

      return plantList;
    }
  }
}