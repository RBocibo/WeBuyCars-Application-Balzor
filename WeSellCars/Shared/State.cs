using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class State
    {
        public Menu Menu { get; } = new Menu();
        public BuyNow Buy { get; } = new BuyNow();
        public UI UI { get; set; } = new UI();

        public decimal TotalPrice => Buy.Orders.Sum(id => Menu.GetCar(id)!.Price);

    }
}
