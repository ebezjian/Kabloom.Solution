using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KabloomLocationsApi.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string Country {get;set;}
        public string FormattedAddress {get;set;}

        public static List<Location> GetLocations()
        {
            var apiCallTask = ApiHelper.ApiCall();
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            
            List<Location> locationList = JsonConvert.DeserializeObject<List<Location>>(jsonResponse["results"].ToString());

            return locationList;
        }

    }
}