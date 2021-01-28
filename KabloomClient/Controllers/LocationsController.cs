using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;


namespace KabloomClient.Controllers
{
  public class LocationsController : Controller
  {
      public IActionResult Index()
      {
        return View();
      }
    }
}