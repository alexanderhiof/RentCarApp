using API.Models;
using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;

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

        public Car car { get; set; }
        public User user { get; set; }

        protected override async Task OnInitializedAsync()
        {
            user = await UserService.GetUser(ownerId);
            car = await CarService.GetCar(id);
        }
        
        public void clickEvent()
        {
            Console.WriteLine("\nStart date: " + startDate + "\n");
            Console.WriteLine("End date: " + endDate + "\n");
            Console.WriteLine("Length of rent: " + (endDate - startDate) + "\n");
            Console.WriteLine("Total price is: " + (endDate - startDate));
        }
    }
}
