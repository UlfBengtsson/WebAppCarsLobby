using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCarsLobby.Models.Cars;

namespace WebAppCarsLobby.Controllers
{
    public class CarsController : Controller
    {
        ICarService _carService;

        public CarsController()
        {
            _carService = new CarService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_carService.GetCars());
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateCarViewModel createCar = new CreateCarViewModel();
            createCar.BrandList = _carService.Getbrands();

            return View(createCar);
        }

        [HttpPost]
        public IActionResult Create(CreateCarViewModel createCar)
        {
            if (ModelState.IsValid)
            {
                _carService.CreateCar(createCar);
                return RedirectToAction("Index");
            }

            createCar.BrandList = _carService.Getbrands();

            return View(createCar);
        }
    }
}
