using API.Models;

namespace RentalWebApp.Services
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetCars();
        Task<Car> GetCar(int id);

        Task AddCar(Car car);
    }
}
