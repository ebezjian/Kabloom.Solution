using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KabloomClient.Models
{
  public class Location
    {
      public string Address { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string Country { get; set; }
      public IList<string> FormattedAddress { get; set; }
    }
  public class LocationGroup
  {
    public string Name { get; set; }
    public string Id { get; set; }
    public Location Location { get; set; }
    public static List<LocationGroup> GetVenues()
    {
      var searchLocation ="Seattle, WA";
      var apiCallTask = ApiHelper.FourSquareCall(searchLocation);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LocationGroup> dummy = JsonConvert.DeserializeObject<List<LocationGroup>>(jsonResponse["response"]["venues"].ToString());

      return dummy;
    }
  }
}