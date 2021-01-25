using Microsoft.AspNetCore.Mvc;
using KabloomApi.Models;

namespace KabloomApi.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var allPlants = Plant.GetPlants("[JZzbz5ld2jLv7RU-HDGVfgPHGH-MPKVMjaVDUowBO1w]");
      return View(allPlants);
    }
  }
}