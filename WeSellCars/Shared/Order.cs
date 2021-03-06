using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; } 
        public int CustomerId { get; set; }
        public List<CarOrder> CarOrders { get; set;}
        public decimal TotalPrice { get; set; }
    }
}
