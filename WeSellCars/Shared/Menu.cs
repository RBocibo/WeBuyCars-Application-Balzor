using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class Menu
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public Car? GetCar(int id)
        {
            return Cars.FirstOrDefault(c => c.CarId == id);
        }
    }
}
