using System.Net.Http.Json;
using WeSellCars.Shared;

namespace WeSellCars.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu()
        {
            var cars = await httpClient.GetFromJsonAsync<Car[]>("/cars");
            return new Menu { Cars = cars!.ToList() };
        }
    }
}
