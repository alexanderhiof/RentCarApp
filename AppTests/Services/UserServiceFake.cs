using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
                    Id = 2,
                    Name = "Sander van der Velden",
                    BirthDate = new DateTime(1990, 1, 12)
                },
                new User()
                {
                    Id = 6,
                    Name = "Samantha Huisman",
                    BirthDate = new DateTime(2002, 9, 12)
                },
                new User()
                {
                    Id = 9,
                    Name = "Aaron Spierings",
                    BirthDate = new DateTime(1990, 6, 3)
                }
            };
        }

        public User GetUser(int id)
        {
            User user = null;
            
            foreach (var users in _users)
            {
                if (users.Id == id)
                {
                    user = users;
                }
            }
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            var users = new List<User>();
            foreach (var user in _users)
            {
                if (user.Id != null)
                {
                    users.Add(user);
                }
            }
            return users;
        }
    }
}
