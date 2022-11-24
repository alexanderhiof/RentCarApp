using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    public class UserServiceFake : IUserServiceFake
    {
        private readonly List<User> _users;

        public UserServiceFake()
        {
            _users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "John Doe",
                    BirthDate = new DateTime(1990, 4, 9)
                },
                new User()
                {
                    Id = 1,
                    Name = "Sander van der Velden",
                    BirthDate = new DateTime(1990, 1, 12)
                },
                new User()
                {
                    Id = 1,
                    Name = "Samantha Huisman",
                    BirthDate = new DateTime(2002, 9, 12)
                },
                new User()
                {
                    Id = 1,
                    Name = "Aaron Spierings",
                    BirthDate = new DateTime(1990, 6, 3)
                }
            };
        }

        public Task<User> GetUser(int id)
        {
            User? user = null;
            
            foreach (var users in _users)
            {
                if (users.Id == id)
                {
                    user = users;
                }
            }
            return user;
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
