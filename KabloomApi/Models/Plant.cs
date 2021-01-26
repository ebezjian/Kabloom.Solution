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
    public string Description { get; set; }
    public string Color { get; set; }
    public string image_url { get; set; }

    public bool Vegetable { get; set; }
    public bool Edible { get; set; }
    public string Toxicity { get; set; }

    public string Minimum_percipitation { get; set; }
    public string Maximum_percipitation { get; set; }
    public string Minimum_temperature { get; set; }
    public string Maximum_temperature { get; set; }

    public string Bloom_months { get; set; }
    public string Growth_months { get; set; }
    public string Growth_rate { get; set; }

    public virtual ApplicationUser User { get; set; }

    public static List<Plant> GetPlants()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      
      List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["data"].ToString());

      return plantList;
    }
  }
}