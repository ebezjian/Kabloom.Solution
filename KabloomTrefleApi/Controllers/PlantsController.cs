using Microsoft.AspNetCore.Mvc;
using KabloomTrefleApi.Models;

namespace KabloomTrefleApi.Controllers
{
  // [Route("api/[controller]")]
  // [ApiController]
  public class PlantsController : Controller //maybe ControllerBase?
  {
    public IActionResult Index()
    {
      var allPlants = Plant.GetPlants();
      return View(allPlants);
    }
  }
}