using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    //In this service you don't need currentUserId to check permissons, role of user contains in identity.
    public class ModeratorService: IModeratorService
    {
        private readonly IModeratorRepository _moderatorRepository;

        public ModeratorService(IModeratorRepository moderatorRepository)
        {
            _moderatorRepository = moderatorRepository;
        }

        /// <summary>
        ///   Restrict access to data.
        /// </summary>
        /// <param name="id">Id of user to ban.</param>
        /// <returns>
        ///    Banned user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<User> BanUser(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Give access to data.
        /// </summary>
        /// <param name="id">Id of user to remove ban.</param>
        /// <returns>
        ///    Unbanned user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<User> RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Close order.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <returns>
        ///    Closed order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Order> CloseOrder(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="country">Country of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<IQueryable<Order>> GetApiOrderDetailsModels(string education, string country, string city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Order> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add country.
        /// </summary>
        /// <param name="country">Country to add.</param>
        /// <returns>
        ///    Added country.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<Country> AddCountry(Country country)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit country.
        /// </summary>
        /// <param name="country">Country to edit.</param>
        /// <returns>
        ///    Edited country.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Country> EditCountry(Country country)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove country.
        /// </summary>
        /// <param name="id">Id of country to remove.</param>
        /// <returns>
        ///    Removed country.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Country> RemoveCountry(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add city.
        /// </summary>
        /// <param name="city">City to add.</param>
        /// <returns>
        ///    Added city.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<City> AddCity(City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit city.
        /// </summary>
        /// <param name="city">City to edit.</param>
        /// <returns>
        ///    Edited city.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<City> EditCity(City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove city.
        /// </summary>
        /// <param name="id">Id of city to remove.</param>
        /// <returns>
        ///    Removed city.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<City> RemoveCity(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add skill.
        /// </summary>
        /// <param name="skill">Skill to add.</param>
        /// <returns>
        ///    Added skill.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<Skill> AddSkill(Skill skill)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit skill.
        /// </summary>
        /// <param name="skill">Skill to edit.</param>
        /// <returns>
        ///    Edited skill.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Skill> EditSkill(Skill skill)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove skill.
        /// </summary>
        /// <param name="id">Id of skill to remove.</param>
        /// <returns>
        ///    Removed skill.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }

    }
}
