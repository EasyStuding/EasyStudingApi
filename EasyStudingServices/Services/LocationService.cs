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

        public IQueryable<Country> GetCountries()
        {
            return _countryRepository.GetAll();
        }

        public IQueryable<Region> GetRegions(long countryId)
        {
            return _regionRepository.GetAll().Where(r => r.CountryId == countryId);
        }

        public IQueryable<City> GetCities(long regionId)
        {
            return _cityRepository.GetAll().Where(c => c.RegionId == regionId);
        }

        public async Task<Country> GetCountry(long id)
        {
            return await _countryRepository.GetAsync(id);
        }

        public async Task<Region> GetRegion(long id)
        {
            return await _regionRepository.GetAsync(id);
        }

        public async Task<City> GetCity(long id)
        {
            return await _cityRepository.GetAsync(id);
        }
    }
}
