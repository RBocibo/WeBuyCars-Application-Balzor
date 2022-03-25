using Microsoft.AspNetCore.Components;
using WeSellCars.Shared;

namespace WeSellCars.Client.Pages
{
    public partial class CarList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Car> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Car> Selected { get; set; }
    }
}
