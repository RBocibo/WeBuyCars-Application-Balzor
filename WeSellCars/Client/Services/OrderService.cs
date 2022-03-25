using System.Net.Http.Json;
using WeSellCars.Shared;

namespace WeSellCars.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient httpClient;
        public OrderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask PlaceOrder(BuyNow cart)
        {
            await httpClient.PostAsJsonAsync("/orders", cart);
        }
    }
}
