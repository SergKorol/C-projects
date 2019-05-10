using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;

namespace GlobalCityManager.Controllers
{
    public class CountryController : Controller
    {
        private readonly worldContext _context;

        public CountryController()
        {
            _context = new worldContext();
        }

        public IActionResult Index()
        {
            IQueryable<Country> countries = from country in _context.Country select country;
            var listCountries = countries.ToList();

            return View(listCountries);
        }


        //Show
        public IActionResult ShowDetail(string id)
        {

            var sCountry = _context.Country.Find(id);

            if (sCountry != null)

                return View("Detail", sCountry);
            else
                return RedirectToAction("Index");

        }

       //Create
       [HttpGet]
       public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country newCountry)
        {
            if (ModelState.IsValid)
            {
                _context.Country.Add(newCountry);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(string id)
        {
            return View(_context.Country.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Country uCountry)
        {
            if (ModelState.IsValid)
            {
                _context.Country.Update(uCountry);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uCountry);
        }
        //Delete
        public IActionResult Delete(string id)
        {

            var dCountry = _context.Country.Find(id);

            if (dCountry != null)
            {
                _context.Country.Remove(dCountry);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");

        }
    }
}
