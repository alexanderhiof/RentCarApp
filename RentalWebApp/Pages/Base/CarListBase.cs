using API.Models;
using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;

namespace RentalWebApp.Pages.Base
{
    public class CarListBase : ComponentBase
    {
        [Inject]
        public ICarService? CarService { get; set; }
        public IEnumerable<API.Models.Car>? Cars { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Cars = (await CarService.GetCars()).ToList();
        }
    }
}
