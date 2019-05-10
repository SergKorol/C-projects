using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalCityManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobalCityManager.Controllers
{
    public class CityController : Controller
    {
        private readonly worldContext _contextCity;

        public CityController()
        {
            _contextCity = new worldContext();
        }

        public IActionResult Index()
        {
            IQueryable<City> cities = from city in _contextCity.City select city;
            var listCountries = cities.ToList();

            return View(listCountries);
        }

        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(City newCity)
        {
            if (ModelState.IsValid)
            {
                _contextCity.City.Add(newCity);
                _contextCity.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_contextCity.City.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(City uCity)
        {
            if (ModelState.IsValid)
            {
                _contextCity.City.Update(uCity);
                _contextCity.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uCity);
        }

        //Delete
        public IActionResult Delete(string id)
        {

            var dCity = _contextCity.City.Find(id);

            if (dCity != null)
            {
                _contextCity.City.Remove(dCity);
                _contextCity.SaveChanges();
            }

            return RedirectToAction("Index");

        }
    }
}
