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
            var allPlants = Plant.GetPlants();
            return View(allPlants);
        }

        public IActionResult Details(int id)
        {
            var thisPlant = Plant.GetDetails(id);
            return View(thisPlant);
        }
    }
}