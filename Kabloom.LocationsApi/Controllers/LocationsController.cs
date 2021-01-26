using KabloomLocationsApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KabloomLocationsApi.Controllers
{
    [Route("api/[controller]")]
    public class LocationsController : Controller
    {
    [HttpGet]
    public IActionResult Index()
    {
      var allLocations = Location.GetLocations();
      return View(allLocations);
    }

      // [HttpGet]
      // public ActionResult<string> Get()
      // {
        // var allLocations = Location.GetLocations(EnvironmentVariables.ClientId, EnvironmentVariables.ClientSecret);
        // return Json(allLocations);
      // }
    }
}