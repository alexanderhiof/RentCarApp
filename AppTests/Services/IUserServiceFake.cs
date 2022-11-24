using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    public interface IUserServiceFake
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}
