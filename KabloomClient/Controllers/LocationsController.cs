using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;

namespace KabloomClient.Controllers
{
  [Route("api/[controller]/{searchLocation}")]
  [ApiController]
  public class LocationsController : ControllerBase
  {
    public ActionResult<List<LocationCallData>> GetLocations(string searchLocation)
    {
      List<LocationCallData> callList = LocationCallData.GetVenues2(searchLocation);
      Console.WriteLine(callList);
      return callList;
    }
  }
}