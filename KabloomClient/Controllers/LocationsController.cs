using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;
using KabloomClient.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KabloomClient.Controllers
{
  [Route("api/locationsapi/{searchLocation}")]
  [ApiController]
  public class LocationsApiController : ControllerBase
  {
    public ActionResult<List<LocationCallData>> GetLocations(string searchLocation)
    {
      List<LocationCallData> callList = LocationCallData.GetVenues2(searchLocation);
      // Console.WriteLine(callList);
      return callList;
    }
  }

  public class LocationsController : Controller
  {
    public IActionResult Index(string searchLocation)
    {
    ViewBag.searchLocation = LocationCallData.GetVenues2(searchLocation);
    return View(searchLocation);
    }
  }
}