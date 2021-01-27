using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace KabloomClient.Models
{
  public class LocationCallData
  {
    public static List<LocationCallData> GetVenues2(string searchLocation)
    {
      var apiCallTask = ApiHelper.FourSquareCall(searchLocation);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LocationCallData> dummy = JsonConvert.DeserializeObject<List<LocationCallData>>(jsonResponse["response"]["venues"].ToString());
      return dummy;
    }
    public string Name { get; set; }
    public string Id { get; set; }
    public Location Location { get; set; }
  }

  public class Location
  {
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public IList<string> FormattedAddress { get; set; }
  }
}