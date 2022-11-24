using API.Controllers;
using RentalWebApp.Services;
using Xunit;

namespace AppTests
{
    public class ApiTests
    {
        private readonly RentalController _rentalController;
        private readonly IRentalService _rentalService;
        public void ApiTest()
        {
            _rentalController = new RentalController(_rentalService);
        }

    }
}