﻿using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    
    public class CarServiceFake : ICarServiceFake
    {
        private readonly List<Car> _cars;
        public CarServiceFake()
        {
            _cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    CarName = "Volvo",
                    CarModel = "V70",
                    ProductionYear = 2000,
                    ImageUrl = "test.jpg",
                    Price = 200,
                    Seats = 5,
                    UserId = 1
                },
                new Car()
                {
                    Id = 2,
                    CarName = "Ferrari",
                    CarModel = "458",
                    ProductionYear = 2014,
                    ImageUrl = "test.jpg",
                    Price = 700,
                    Seats = 5,
                    UserId = 3
                },
                new Car()
                {
                    Id = 3,
                    CarName = "Audi",
                    CarModel = "A4",
                    ProductionYear = 2018,
                    ImageUrl = "test.jpg",
                    Price = 400,
                    Seats = 5,
                    UserId = 2
                }
            };
        }
        
        
        public IEnumerable<Car> GetCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCar(int id)
        {
            Car car = null;

            foreach (var cars in _cars)
            {
                if (cars.Id == id)
                {
                    car = cars;
                }
            }
            return car;
        }

        public Car AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Car DeleteCar(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}