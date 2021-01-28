using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;
using System.Collections.Generic;


namespace KabloomClient.Controllers
{
  public class LocationsController : Controller
  {
      public IActionResult Index()
      {
        List<LocationGroup> venues = LocationGroup.GetVenues();
        return View(venues);
      }
    }
}