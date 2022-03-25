using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class ConsoleOrderService : IOrderService
    {
        public ValueTask PlaceOrder(BuyNow cart)
        {
            Console.WriteLine($"Placing a car order for {cart.Customer.CustomerName}");
            return new ValueTask();
        }
    }
}
