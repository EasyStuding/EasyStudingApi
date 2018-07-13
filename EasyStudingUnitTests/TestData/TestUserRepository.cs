using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestUserRepository : IRepository<User>
    {
        private FakeData _fakeData;

        public TestUserRepository()
        {
            _fakeData = new FakeData();
        }
        public IQueryable<User> GetAll()
        {
            return _fakeData.Users.AsQueryable();
        }

        public async Task<User> GetAsync(long id)
        {
            return _fakeData.User;
        }

        public async Task<User> AddAsync(User param)
        {
            return _fakeData.User;
        }

        public async Task<User> EditAsync(User param)
        {
            return _fakeData.User;
        }

        public async Task<User> RemoveAsync(long id)
        {
            return _fakeData.User;
        }
    }
}
