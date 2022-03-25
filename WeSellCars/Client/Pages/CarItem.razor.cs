using Microsoft.AspNetCore.Components;
using WeSellCars.Shared;

namespace WeSellCars.Client.Pages
{
    public partial class CarItem
    {
        [Parameter]
        public Car Car { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Car> Selected { get; set; }
        private string SpicinessImage(CarType carType)
        => $"images/{carType.ToString().ToLower()}.jpg";
    }
}

