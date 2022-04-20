using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Models.Cars
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<string> Getbrands();
        Car CreateCar(CreateCarViewModel createCar);
        Car GetById(int id);
    }
}
