using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeSellCars.Shared;

namespace WeSellCars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly WeSellCarsDataContext _context;

        public CarsController(WeSellCarsDataContext context)
        {
            _context = context;
        }

        [HttpGet("/cars")]
        public IQueryable<Car> GetCars()
        {
            return _context.Cars;
        }

        [HttpPost]
        public IActionResult InsertCar([FromBody] Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
            return Created($"cars/{car.CarId}", car);
        }
    }
}
