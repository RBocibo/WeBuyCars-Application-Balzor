using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public BuyNow Buy { get; set; } = new BuyNow();
        public UI UI { get; set; } = new UI();

        public decimal TotalPrice 
            => Buy.Orders.Sum(id => Menu.GetCar(id).Price);
        public Car CurrentCar { get; set; } = new Car() { Name = "xxx" };

    }
}
