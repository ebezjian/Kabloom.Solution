using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KabloomLocationsApi.Models;

namespace KabloomLocationsApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController : ControllerBase
  {
    public ActionResult<List<LocationCallData>> Get()
    {
      // if (searchLocation != null)
      // {
        List<LocationCallData> callList = LocationCallData.GetVenues();
        Console.WriteLine(callList);
        return callList;  
      // }
      // else
      // {
      //   return null;
      // }
    }
  }
}