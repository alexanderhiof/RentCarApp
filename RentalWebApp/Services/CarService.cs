using API.Models;

namespace RentalWebApp.Services
{
    public class CarService : ICarService
    {
        private readonly HttpClient _httpClient;
        public CarService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<IEnumerable<Car>> GetCars()
        {
            Car[]? cars = await _httpClient.GetFromJsonAsync<Car[]>("api/Car");
            return cars;
        }

        public async Task<Car> GetCar(int id)
        {
            Car? car = await _httpClient.GetFromJsonAsync<Car>("api/Car/" + id);
            return car;
        }
    }
}
