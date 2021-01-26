using Microsoft.AspNetCore.Mvc;
using KabloomLocationsApi.Models;

namespace KabloomLocationsApi.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var allLocations = Location.GetLocations();
      return View(allLocations);
    }
  }
}