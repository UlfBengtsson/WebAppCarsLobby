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
                string[] saab = new string[] { "SAAB","900s","8500 Kr" };
                string[] volvo = new string[] { "Volvo","740 GLT","4600 Kr" };
                string[] bmw = new string[] { "BMW","M3","14900 Kr" };
                carsStorage.Add(saab);
                carsStorage.Add(volvo);
                carsStorage.Add(bmw);
            }
        }

        public IActionResult Index()
        {
            ViewBag.Cars = carsStorage;
            return View();
        }
    }
}
