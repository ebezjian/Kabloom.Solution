using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;

namespace KabloomClient.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController : ControllerBase
  {
    public ActionResult<List<LocationCallData>> GetLocations()
    {
        List<LocationCallData> callList = LocationCallData.GetVenues();
        Console.WriteLine(callList);
        return callList;
    }
  }
}