using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCarsLobby.Models;

namespace WebAppCarsLobby.Controllers
{
    public class CarsController : Controller
    {
        CarService _carService;

        public CarsController()
        {
            _carService = new CarService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Cars = _carService.GetCars();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Brands = _carService.Getbrands();
            return View();
        }

        [HttpPost]
        public IActionResult Create(string brand, string model, string price)
        {
            try
            {
                _carService.Create(brand, model, price);

                return RedirectToAction("Index");
            }
            catch (ArgumentException exceptionData)
            {
                ViewBag.ExceptionMsg = exceptionData.Message;
            }

            ViewBag.Brand = brand;
            ViewBag.Model = model;
            ViewBag.Price = price;
            ViewBag.Brands = _carService.Getbrands();

            return View();
        }
    }
}
