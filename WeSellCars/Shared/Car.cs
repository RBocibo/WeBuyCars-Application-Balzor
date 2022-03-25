using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class Car
    {
        public Car(int id,  string name, string model, decimal price, CarType carType)
        {
            CarId = id;
            Name = name;
            Model = model;
            Price = price;
            CarType = carType;
        }

        public int CarId { get; }
        public string Name { get; }
        public string Model { get; }
        public decimal Price { get; }
        public CarType CarType { get; set; }
    }
}
