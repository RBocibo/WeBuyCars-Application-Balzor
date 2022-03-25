using Microsoft.AspNetCore.Components;
using WeSellCars.Shared;

namespace WeSellCars.Client.Pages
{
    public partial class Cart
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Car> GetCarFromId { get; set; }
        = default!;
        private IEnumerable<(Car car, int pos)> Cars { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Cars = Orders.Select((id, pos)
                    => (car: GetCarFromId(id), pos: pos));
            TotalPrice = Cars.Select(tuple => tuple.car.Price).Sum();
        }
    }
}
