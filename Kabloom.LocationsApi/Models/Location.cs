using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

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

    // public static List<Location> GetLocations()
    // {
      // var apiCallTask = ApiHelper.ApiCall();
      // var result = apiCallTask.Result;

			// Location location = new Location();
			// location.Name = "one";
			// location.LocationId = 7;
			// string result = JsonConvert.SerializeObject(location);

			// JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);

			// Console.WriteLine(jsonResponse);
			// Console.WriteLine(jsonResponse["Name"]);

			// List<Location> dummy = JsonConvert.DeserializeObject<List<Location>>(jsonResponse["response.venues"].ToString());
			// return dummy;
    // }

  }
}