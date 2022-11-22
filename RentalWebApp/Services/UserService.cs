using API.Models;

namespace RentalWebApp.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<IEnumerable<User>> GetUsers()
        {
            User[]? users = await _httpClient.GetFromJsonAsync<User[]>("api/User");
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            User? user = await _httpClient.GetFromJsonAsync<User>("api/User/" + id);
            return user;
        }
    }
}
