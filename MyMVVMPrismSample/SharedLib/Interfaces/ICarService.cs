using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Interfaces
{
    public interface ICarService
    {
        Car GetCar();

        IEnumerable<Car> GetCars();
    }
}
