using System;
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

        public static List<Plant> GetPlants()
        {
            var apiCallTask = ApiHelper.ApiCall();
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);

            Console.WriteLine(jsonResponse);
            List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse["data"].ToString());

            return plantList;
        }

        public static Plant GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Plant plant = JsonConvert.DeserializeObject<Plant>(jsonResponse.ToString());

            return plant;
        }

        public static void Post(Plant plant)
        {
            string jsonPlant = JsonConvert.SerializeObject(plant);
            var apiCallTask = ApiHelper.Post(jsonPlant);
        }

        public static void Put(Plant plant)
        {
            string jsonPlant = JsonConvert.SerializeObject(plant);
            var apiCallTask = ApiHelper.Put(plant.PlantId, jsonPlant);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }
    }
}