using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class HardCodedCarMenu : IMenuService
    {
        public ValueTask<Menu> GetMenu()
        => new ValueTask<Menu>(
        new Menu
        {
            Cars = new List<Car>()
            {
                        
                new Car(1, "BMW", "M3", 1300000, CarType.SportsCar),
            
                new Car(2, "VW", "Tiguan", 700000, CarType.SUV),
            
                new Car(3, "Toyota", "Corolla", 350000, CarType.Seadan),
            
                new Car(4, "Toyota", "Quantum", 500000, CarType.Taxi),
            
                new Car(5, "Ford", "Ranger", 600000, CarType.MiniVan)

            }
        });
    }
}
