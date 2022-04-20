using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Models.Cars
{
    public class CarService : ICarService
    {
        static int idCounter = 0;
        static List<Car> carStorage = new List<Car>();
        static List<string> brandsStorage = new List<string>();

        public CarService()
        {
            if (brandsStorage.Count == 0)
            {
                brandsStorage.Add("SAAB");
                brandsStorage.Add("Volvo");
                brandsStorage.Add("BMW");
                brandsStorage.Add("Opel");
                brandsStorage.Add("VW");
                brandsStorage.Add("Mazda");

                carStorage.Add(new Car() { Id = ++idCounter, Brand="SAAB", ModelName = "900s", Price = 8500 });
                carStorage.Add(new Car() { Id = ++idCounter, Brand= "Volvo", ModelName = "740 GLT", Price = 4600 });
                carStorage.Add(new Car() { Id = ++idCounter, Brand= "BMW", ModelName = "M3", Price = 14900 });
            }
        }

        public Car CreateCar(CreateCarViewModel createCar)
        {
            Car car = new Car() { Id = ++idCounter, Brand = createCar.Brand, ModelName = createCar.ModelName, Price = createCar.Price };
            carStorage.Add(car);
            return car;
        }

        public List<string> Getbrands()
        {
            return brandsStorage;
        }

        public Car GetById(int id)
        {
            foreach (Car car in carStorage)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;
        }

        public List<Car> GetCars()
        {
            return carStorage;
        }
    }
}
