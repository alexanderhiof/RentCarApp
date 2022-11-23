using API.Models;

namespace RentalWebApp.Services
{
    public class RentalService : IRentalService
    {
        private readonly HttpClient _httpClient;
        public RentalService(HttpClient httpClient) => _httpClient = httpClient;

        public Task<Rental> GetRentalForTenant(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Rental>> GetRentalsForTenant(int tenantId)
        {
            Rental[]? rentals = await _httpClient.GetFromJsonAsync<Rental[]>("api/Rental/t/" + tenantId);
            return rentals;
        }
        public async Task AddRental(Rental rental)
        {
            await _httpClient.PostAsJsonAsync("api/Rental", rental);
        }


        public async Task DeleteRentalBasedOnCar(int id)
        {
            await _httpClient.DeleteAsync("api/Rental/" + id);
        }
    }
}
