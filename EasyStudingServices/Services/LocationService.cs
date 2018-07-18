using EasyStudingInterfaces.Repositories;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    public class LocationService : ILocationService
    {
        #region Initialize repositories.

        private readonly IRepository<Country> _countryRepository;
        private readonly IRepository<Region> _regionRepository;
        private readonly IRepository<City> _cityRepository;


        public LocationService(IRepository<Country> countryRepository,
            IRepository<Region> regionRepository,
            IRepository<City> cityRepository)
        {
            _countryRepository = countryRepository;
            _regionRepository = regionRepository;
            _cityRepository = cityRepository;
        }


        #endregion

        /// <summary>
        ///   Get all countries.
        /// </summary>
        /// <returns>
        ///    Countries.
        /// </returns>

        public IQueryable<Country> GetCountries()
        {
            return _countryRepository.GetAll();
        }

        /// <summary>
        ///   Get all regions by country id.
        /// </summary>
        /// <param name="countryId">Id of country.</param>
        /// <returns>
        ///    Regions.
        /// </returns>

        public IQueryable<Region> GetRegions(long countryId)
        {
            return _regionRepository.GetAll().Where(r => r.CountryId == countryId);
        }

        /// <summary>
        ///   Get all cities by region id.
        /// </summary>
        /// <param name="regionId">Id of region.</param>
        /// <returns>
        ///    Cities.
        /// </returns>

        public IQueryable<City> GetCities(long regionId)
        {
            return _cityRepository.GetAll().Where(c => c.RegionId == regionId);
        }

        /// <summary>
        ///   Get Country by id.
        /// </summary>
        /// <param name="id">Id of entity.</param>
        /// <returns>
        ///    Country.
        /// </returns>

        public async Task<Country> GetCountry(long id)
        {
            return await _countryRepository.GetAsync(id);
        }

        /// <summary>
        ///   Get Region by id.
        /// </summary>
        /// <param name="id">Id of entity.</param>
        /// <returns>
        ///    Region.
        /// </returns>

        public async Task<Region> GetRegion(long id)
        {
            return await _regionRepository.GetAsync(id);
        }

        /// <summary>
        ///   Get City by id.
        /// </summary>
        /// <param name="id">Id of entity.</param>
        /// <returns>
        ///    City.
        /// </returns>

        public async Task<City> GetCity(long id)
        {
            return await _cityRepository.GetAsync(id);
        }
    }
}
