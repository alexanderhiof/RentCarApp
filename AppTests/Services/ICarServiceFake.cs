using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    public interface ICarServiceFake
    {
        IEnumerable<Car> GetCars();
        Car GetCar(int id);

        List<Car> AddCar(Car car);

        Car DeleteCar(int id);
    }
}
