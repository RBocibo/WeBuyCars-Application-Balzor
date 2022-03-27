using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public interface IMenuService
    {
        Task<Menu> GetMenu();
    }
}