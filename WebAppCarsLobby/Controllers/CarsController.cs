using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Controllers
{
    public class CarsController : Controller
    {
        static List<string[]> carsStorage;

        public CarsController()
        {
            if (carsStorage == null)
            {
                carsStorage = new List<string[]>();
                string[] saab = new string[] { "SAAB","900s","8500" };
                string[] volvo = new string[] { "Volvo","740 GLT","4600" };
                string[] bmw = new string[] { "BMW","M3","14900" };
                carsStorage.Add(saab);
                carsStorage.Add(volvo);
                carsStorage.Add(bmw);
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Cars = carsStorage;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Brands = new string[]
            {
                "SAAB",
                "Volvo",
                "BMW",
                "Opel",
                "VW",
                "Mazda"
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(string brand, string model, string price)
        {
            string[] newCar = new string[] { brand, model, price };
            
            carsStorage.Add(newCar);

            return RedirectToAction("Index");
        }
    }
}
