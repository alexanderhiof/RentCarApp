using API.Models;
using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;
using RentalWebApp.State;

namespace RentalWebApp.Pages.Base
{
    public class RentalsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IRentalService? RentalService { get; set; }
        [Inject]
        public ICarService? CarService { get; set; }
        public IEnumerable<API.Models.Rental>? Rentals { get; set; }
        public IEnumerable<API.Models.Car>? Cars { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Cars = (await CarService.GetCars()).ToList();
            Rentals = (await RentalService.GetRentalsForTenant(Id)).ToList();
        }
    }
}


