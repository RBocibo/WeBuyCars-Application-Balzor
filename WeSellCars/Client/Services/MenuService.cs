using WeSellCars.Shared;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WeSellCars.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;

        public MenuService(HttpClient httpClient)
          => this.httpClient = httpClient;


        public async Task<Menu> GetMenu()
        {
            Car[] cars = await this.httpClient.GetFromJsonAsync<Car[]>("/cars");
            return new Menu { Cars = cars.ToList() };
        }
    }
}