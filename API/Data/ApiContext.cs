using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rental { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
