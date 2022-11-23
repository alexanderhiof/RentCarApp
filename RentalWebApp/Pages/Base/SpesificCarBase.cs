using API.Models;
using Blazorise;
using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;
using RentalWebApp.State;

namespace RentalWebApp.Pages.Base
{
    public class SpesificCarBase : ComponentBase
    {
        public DateTime? startDate;
        public DateTime? endDate;


        [Parameter]
        public int ownerId { get; set; }
        [Parameter]
        public int id { get; set; }

        [Inject]
        public ICarService? CarService { get; set; }

        [Inject]
        public IUserService? UserService { get; set; }

        [Inject]
        public IRentalService? RentalService { get; set; }

        [Inject]
        public State.appstate appState { get; set; }

        public Car car { get; set; }
        public User user { get; set; }

        protected override async Task OnInitializedAsync()
        {
            user = await UserService.GetUser(ownerId);
            car = await CarService.GetCar(id);
        }

        public double clickEvent()
        {

            if (startDate == null || endDate == null)
            {
                return 0;
            } else {
                
                return (new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day)
                    - new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day)).Days * car.Price;
            }
            
        }

        public async Task AddRental()
        {
            _ = RentalService.AddRental(new Rental
            {
                CarId = car.Id,
                StartDate = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day),
                EndDate = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day),
                Price = car.Price,
                UserId = car.UserId,
                Tenant = appState.UserId
            });
        }
    }
}
