using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeSellCars.Shared;

namespace WeSellCars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly WeSellCarsDataContext _context;
        public OrdersController(WeSellCarsDataContext context)
        {
            _context = context;
        }
        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] BuyNow cart)
        {
            Order order = new Order();
            order.Customer = cart.Customer;
            order.Cars = new List<Car>();
            foreach (int carId in cart.Orders)
            {
                var car = _context.Cars.Single(p => p.CarId == carId);
                order.Cars.Add(car);
            }
            _context.Orders.Add(order);
            _context.SaveChanges();
            return Created("/orders", order.Id);
        }
    }
}
