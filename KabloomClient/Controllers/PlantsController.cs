
using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;


namespace KabloomClient.Controllers
{
    public class PlantsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchPlant(string searchString)
        {
            var thisPlant = Plant.GetPlants(searchString);
            return View(thisPlant);
        }
    }
}