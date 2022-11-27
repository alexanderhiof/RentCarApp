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
        private readonly IRentalServiceFake _rentalService;
        private readonly ICarServiceFake _carService;
        private readonly IUserServiceFake _userService;
        public ApiTests()
        {
            _rentalService = new RentalServiceFake();
            _carService = new CarServiceFake();
            _userService = new UserServiceFake();
        }

        [Fact]
        public void GetRentalsForTenantId3() // Checks to see if Tenant 3 has 1 Rental
        {
            // Act
            var okResult = _rentalService.GetRentalsForTenant(3);

            // Assert
            var test = Assert.IsType<List<Rental>>(okResult);
            Assert.Equal(1, test.Count);

        }

        [Fact]
        public void GetRentalById7() // Checks if Rental id 7 has Tenant 3 connected
        {
            // Act
            var okResult = _rentalService.GetRentalForTenant(7);

            // Assert
            Assert.Equal(3, okResult.Tenant);
        }


        [Fact]
        public void GetCarById3() // Gets carid 3 and checks if its an element of the Car list
        {
            // Act
            var okResult = _carService.GetCar(3);

            // Assert
            Assert.IsType<Car>(okResult);
        }

        [Fact]
        public void GetUserById6() // Gets user id 6 and checks if its an element of the User list
        {
            // Act
            var okResult = _userService.GetUser(6);

            // Assert
            Assert.IsType<User>(okResult);
        }

        [Fact]
        public void GetUserCount() // Checks if the User list has 4 elements
        {
            // Act
            var okResult = _userService.GetUsers();

            // Assert
            var test = Assert.IsType<List<User>>(okResult);
            Assert.Equal(4, test.Count);
        }

        [Fact]
        public void AddingCar() // Checks if adding a car takes the list from 3 to 4
        {
            // Act
            var okResult = _carService.AddCar(new Car()
            {
                Id = 4,
                CarName = "Audi",
                CarModel = "A4",
                ProductionYear = 2018,
                ImageUrl = "test.jpg",
                Price = 400,
                Seats = 5,
                UserId = 2
            });

            // Assert
            var test = Assert.IsType<List<Car>>(okResult);
            Assert.Equal(4, test.Count);
        }

        [Fact]
        public void DeleteCar() // Checks if deleting a car takes the list from 3 to 2
        {
            // Act
            var okResult = _carService.DeleteCar(3);

            // Assert
            var test = Assert.IsType<List<Car>>(okResult);
            Assert.Equal(2, test.Count);
        }

    }
}