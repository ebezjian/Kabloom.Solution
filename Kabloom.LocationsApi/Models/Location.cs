using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace KabloomLocationsApi.Models
{
  public class LocationCallData
  {
    // public int Id { get; set; }
    public string Name {get;set;}
    public string Address {get;set;}
    public string City {get;set;}
    public string State {get;set;}
    public string Country {get;set;}
    public string FormattedAddress {get;set;}

    public static List<LocationCallData> GetVenues()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LocationCallData> dummy = JsonConvert.DeserializeObject<List<LocationCallData>>(jsonResponse["response"]["venues"].ToString());
      return dummy;
    }
  }
}