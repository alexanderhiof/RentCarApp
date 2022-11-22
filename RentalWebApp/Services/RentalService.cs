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
    }
}
