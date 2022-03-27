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
            Customer customer = cart.Customer;
            var order = new Order()
            {
                CarOrders = new List<CarOrder>()
            };
            customer.Order = order;

            foreach (int carId in cart.Orders)
            {
                Car car = _context.Cars.Single(o => o.CarId == carId);
                order.CarOrders.Add(new CarOrder { Car = car, Order = order});
            }

            order.TotalPrice = order.CarOrders.Sum(co => co.Car.Price);

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok();
        }
    }
}
