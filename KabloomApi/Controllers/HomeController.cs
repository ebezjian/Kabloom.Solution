using Microsoft.AspNetCore.Mvc;
using KabloomApi.Models;

namespace KabloomApi.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var allPlants = Plant.GetPlants();
      return View(allPlants);
    }
  }
}