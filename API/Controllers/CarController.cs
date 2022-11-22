using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ApiContext _context;

        public CarController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> Get()
        {
            return Ok(await _context.Cars.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
                return NotFound();
            return Ok(car);
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(Car car)
        {
            _context.Cars.Add(car);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = car.Id }, car);
        }
    }
}
