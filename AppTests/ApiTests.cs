using API.Controllers;
using API.Models;
using AppTests.Services;
using Microsoft.AspNetCore.Mvc;
using RentalWebApp.Services;
using Xunit;

namespace AppTests
{
    public class ApiTests
    {
        private readonly RentalService _rentalController;
        private readonly IRentalServiceFake _rentalService;
        public ApiTests()
        {
            _rentalService = new RentalServiceFake();
        }

        [Fact]
        public void GetRentalsForTenantId3() // Tests to see if Tenant 3 has 1 Rental
        {
            // Act
            var okResult = _rentalService.GetRentalsForTenant(3);

            // Assert
            var test = Assert.IsType<List<Rental>>(okResult);
            Assert.Equal(1, test.Count);

        }

        [Fact]
        public void GetRentalById7() // Tests if Rental id 7 has Tenant 3 connected
        {
            // Act
            var okResult = _rentalService.GetRentalForTenant(7);

            // Assert
            Assert.Equal(3, okResult.Tenant);
        }


    }
}