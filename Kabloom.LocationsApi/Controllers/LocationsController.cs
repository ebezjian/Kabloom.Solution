using KabloomLocationsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KabloomLocationsApi.Controllers
{
    public class LocationsController : Controller
    {
    [HttpGet]
    public IActionResult Index()
    {
      var allLocations = Location.GetLocations(EnvironmentVariables.ClientId, EnvironmentVariables.ClientSecret);
      return View(allLocations);
    }
  }
}