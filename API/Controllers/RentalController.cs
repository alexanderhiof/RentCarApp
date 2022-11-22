using API.Data;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly ApiContext _context;

        public RentalController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rental>>> Get()
        {
            return Ok(await _context.Rental.ToListAsync());
        }

        [HttpGet("t/{tenantId}")]
        public async Task<ActionResult<IEnumerable<Rental>>> GetRentalsForUser(int tenantId)
        {
            var userRentals = new List<Rental>();
            foreach (var rental in await _context.Rental.ToListAsync())
            {
                if (rental.Tenant == tenantId)
                {
                    userRentals.Add(rental);
                }
            }

            return Ok(userRentals);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var rental = await _context.Rental.FindAsync(id);
            if (rental == null)
                return NotFound();
            return Ok(rental);
        }

        [HttpPost]
        public async Task<IActionResult> AddRental(Rental rental)
        {
            _context.Rental.Add(rental);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = rental.Id }, rental);
        }
    }
}
