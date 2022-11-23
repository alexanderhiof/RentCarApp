using API.Models;
using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;
using RentalWebApp.State;
using System.Net.NetworkInformation;

namespace RentalWebApp.Pages.Base
{
    public class CarListBase : ComponentBase
    {
        public string inputCarName;
        public string inputCarModel;
        public string inputProdYear;
        public string inputImgURL;
        public string inputPricePrDay;
        public string inputCarSeats;

        [Inject]
        public ICarService? CarService { get; set; }
        public IEnumerable<API.Models.Car>? Cars { get; set; }

        [Inject]
        public State.appstate appState { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Cars = (await CarService.GetCars()).ToList();
        }


        public async Task AddCar()
        {
            _ = CarService.AddCar(new Car
            {
                CarName = inputCarName,
                CarModel = inputCarModel,
                ProductionYear = int.Parse(inputProdYear),
                ImageUrl = inputImgURL,
                Price = double.Parse(inputPricePrDay),
                Seats = int.Parse(inputCarSeats),
                UserId = appState.UserId
            });

            NavigationManager.NavigateTo("/");
        }

    }
}
