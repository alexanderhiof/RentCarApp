using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    public class RentalServiceFake : IRentalServiceFake
    {
        private readonly List<Rental> _rentals;
        
        public RentalServiceFake()
        {
            _rentals = new List<Rental>()
            {
                new Rental()
                {
                    Id = 7,
                    CarId = 4,
                    Tenant = 3,
                    StartDate = new DateTime(2021, 1, 1),
                    EndDate = new DateTime(2021, 1, 2),
                    Price = 100,
                    UserId = 3
                },
                new Rental()
                {
                    Id = 3,
                    CarId = 2,
                    Tenant = 1,
                    StartDate = new DateTime(2021, 1, 1),
                    EndDate = new DateTime(2021, 1, 2),
                    Price = 200,
                    UserId = 2
                },
            };
        }
        

        public Rental AddRental(Rental rental)
        {
            throw new NotImplementedException();
        }

        public Rental DeleteRentalBasedOnCar(int id)
        {
            throw new NotImplementedException();
        }

        public Rental GetRentalForTenant(int id)
        {
            Rental rental = null;
            
            foreach (var rentals in _rentals)
            {
                if (rentals.Id == id)
                {
                    rental = rentals;
                }
            }
            return rental;
        }

        public IEnumerable<Rental> GetRentalsForTenant(int tenantId)
        {
            var userRentals = new List<Rental>();
            foreach (var rental in _rentals.ToList())
            {
                if (rental.Tenant == tenantId)
                {
                    userRentals.Add(rental);
                }
            }

            return userRentals;
        }
    }
}
