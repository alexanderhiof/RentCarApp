using Microsoft.AspNetCore.Components;
using RentalWebApp.Services;
using RentalWebApp.State;

namespace RentalWebApp.Pages.Base
{
    public class UserBase : ComponentBase
    {
        [Inject]
        public IUserService? UserService{ get; set; }
        public IEnumerable<API.Models.User>? Users { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Users = (await UserService.GetUsers()).ToList();
        }
    }
}
