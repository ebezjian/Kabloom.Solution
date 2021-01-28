
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KabloomClient.Models
{
  public class Plant
  {
    public int PlantId { get; set; }
    public string Common_name { get; set; }
    public string image_url { get; set; }
    public string author { get; set; }
    public string scientific_name { get; set; }
    public string family_common_name { get; set; }
    public string year { get; set; }


    public virtual ApplicationUser User { get; set; }

    public static List<Plant> GetAllPlants()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["data"].ToString());

      return plantList;
    }
    public static Plant GetPlants(string searchString)
    {
      var apiCallTask = ApiHelper.GetPlants(searchString);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Plant plant = JsonConvert.DeserializeObject<Plant>(jsonResponse.ToString());

      return plant;
    }
  }
}