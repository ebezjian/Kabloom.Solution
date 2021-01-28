using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KabloomClient.Models;
using KabloomClient.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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