using API.Models;

namespace RentalWebApp.Services
{
    public interface IRentalService
    {
        Task<IEnumerable<Rental>> GetRentalsForTenant(int tenantId);
        Task<Rental> GetRentalForTenant(int id);

        Task AddRental(Rental rental);

        Task DeleteRentalBasedOnCar(int id);
    }
}
