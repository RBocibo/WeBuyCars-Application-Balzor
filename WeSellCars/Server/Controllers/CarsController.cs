using Microsoft.AspNetCore.Mvc;
using WeSellCars.Shared;
using System.Linq;

namespace WeSellCars.Server.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {
        
        private readonly WeSellCarsDataContext db;

        public CarsController(WeSellCarsDataContext db)
          => this.db = db;

        [HttpGet("cars")]
        public IQueryable<Car> GetCars()
          => this.db.Cars; 

        [HttpPost("cars")]
        public IActionResult InsertCar([FromBody] Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
            return Created($"cars/{car.CarId}", car);
        }
    }
}
