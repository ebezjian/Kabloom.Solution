using Microsoft.AspNetCore.Mvc;
using KabloomLocationsApi.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KabloomLocationsApi.Controllers
{
  [Produces("application/json")]
	public class HomeController : Controller
  {
		[Route("/")]
		public IActionResult Index()
		{
			var allLocations = Location.GetLocations();
			return View(allLocations);
		}
  }
}