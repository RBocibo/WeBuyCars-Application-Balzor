using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public enum CarType
    {
        SportsCar,
        SUV,
        Seadan,
        Taxi,
        MiniVan
    }
    public class Car
    {
        public Car()
        {

        }
        public Car(int id,  string name, string model, decimal price, CarType carType)
        {
            CarId = id;
            Name = name
                ?? throw new ArgumentNullException(nameof(name),
           "A car needs a name!"); ;
            Model = model;
            Price = price;
            CarType = carType;
        }

        public int CarId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public CarType CarType { get; set; }

        
    }
}
