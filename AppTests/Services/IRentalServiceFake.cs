using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    public interface IRentalServiceFake
    {
        IEnumerable<Rental> GetRentalsForTenant(int tenantId);
        Rental GetRentalForTenant(int id);

        Rental AddRental(Rental rental);

        Rental DeleteRentalBasedOnCar(int id);
    }
}
