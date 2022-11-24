﻿using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.Services
{
    public interface IUserServiceFake
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
    }
}
