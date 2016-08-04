using SharedLib.Interfaces;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Services
{
    public class CarService : ICarService
    {
        public Car GetCar()
        {
            return new Car { Manufacturer = "BMW", Model = "X3" };
        }

        public IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car { Manufacturer = "BMW", Model = "X5" },
                new Car { Manufacturer = "Audi", Model = "A6" },
                new Car { Manufacturer = "VW", Model = "Passat" },
            };
        }
    }
}
