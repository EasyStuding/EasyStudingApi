using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyStudingInterfaces.Services;

namespace EasyStudingRepositories.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private readonly EasyStudingContext _context;
        private readonly IErrorHandler _errorHandler;
        private readonly UnivesalRepository<City> _univesalRepository;
        public CityRepository(EasyStudingContext context, IErrorHandler errorHandler)
        {
            _context = context;
            _errorHandler = errorHandler;
            _univesalRepository =new UnivesalRepository<City>(_context.Cities, _context, _errorHandler);
        }

        public IQueryable<City> GetAll()
        {
            return _context.Cities;
        }

        public async Task<City> GetAsync(long id)
        {
           return await _univesalRepository.GetAsync(id);
            //var cityModel = await _context.Cities.FirstOrDefaultAsync(city => city.Id == id);

            //_errorHandler.CheckIndexOutOfRangeException(cityModel);

            //return cityModel;
        }

        public async Task<City> AddAsync(City city)
        {
            return await _univesalRepository.AddAsync(city);
            //_errorHandler.CheckObjectOfNull(city);

            //await _context.Cities.AddAsync(city);

            //await _context.SaveChangesAsync();

            //return _context.Cities.LastOrDefault();
        }

        public async Task<City> EditAsync(City cityModel)
        {
            _errorHandler.CheckObjectOfNull(cityModel);

            var city = await GetAsync(cityModel.Id);


            city.Name = cityModel.Name;
            city.CountryId = cityModel.CountryId;
            city.Region = cityModel.Region;

            await _context.SaveChangesAsync();

            return city;
        }

        public async Task<City> RemoveAsync(long id)
        {
            //var city = await GetAsync(id);

            //_context.Cities.Remove(city);

            //await _context.SaveChangesAsync();

            //return city;
            return await _univesalRepository.RemoveAsync(id);
        }
    }
}
