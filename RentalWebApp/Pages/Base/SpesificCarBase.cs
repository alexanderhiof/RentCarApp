using API.Models;
using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;

namespace RentalWebApp.Pages.Base
{
    public class SpesificCarBase : ComponentBase
    {
        [Parameter]
        public int ownerId { get; set; }
        [Parameter]
        public int id { get; set; }

        [Inject]
        public ICarService? CarService { get; set; }

        [Inject]
        public IUserService? UserService { get; set; }

        public Car car { get; set; }
        public User user { get; set; }

        protected override async Task OnInitializedAsync()
        {
            user = await UserService.GetUser(ownerId);
            car = await CarService.GetCar(id);
        }
    }
}
