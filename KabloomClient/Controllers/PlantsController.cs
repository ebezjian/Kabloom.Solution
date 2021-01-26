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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Plant plant)
        {
            Plant.Post(plant);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisPlant = Plant.GetDetails(id);
            return View(thisPlant);
        }

        [HttpPost]
        public IActionResult Edit(Plant plant)
        {
            Plant.Put(plant);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Plant.Delete(id);
            return RedirectToAction("Index");
        }
    }
}