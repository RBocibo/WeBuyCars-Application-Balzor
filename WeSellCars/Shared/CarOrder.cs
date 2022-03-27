using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class CarOrder
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Car Car { get; set; }
    }
}
