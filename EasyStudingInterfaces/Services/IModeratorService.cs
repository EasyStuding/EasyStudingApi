using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface IModeratorService
    {
        Task<User> BanUser(long id);

        Task<User> RemoveBanOfUser(long id);

        Task<Order> CloseOrder(long id);

        Task<IQueryable<Order>> GetApiOrderDetailsModels(string education, string country, string city);

        Task<Order> GetApiOrderDetailsModel(long id);

        Task<Country> AddCountry(Country country);
        Task<Country> EditCountry(Country country);
        Task<Country> RemoveCountry(long id);

        Task<City> AddCity(City city);
        Task<City> EditCity(City city);
        Task<City> RemoveCity(long id);

        Task<Skill> AddSkill(Skill skill);
        Task<Skill> EditSkill(Skill skill);
        Task<Skill> RemoveSkill(long id);
    }
}
