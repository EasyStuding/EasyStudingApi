using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestOrderRepository : IRepository<Order>
    {
        private FakeData _fakeData;

        public TestOrderRepository()
        {
            _fakeData = new FakeData();
        }
        public async Task<Order> AddAsync(Order param)
        {
            return _fakeData.Order;
        }

        public async Task<Order> EditAsync(Order param)
        {
            return _fakeData.Order;
        }

        public IQueryable<Order> GetAll()
        {
            return _fakeData.Orders.AsQueryable();
        }

        public async Task<Order> GetAsync(long id)
        {
            return _fakeData.Order;
        }

        public async Task<Order> RemoveAsync(long id)
        {
            return _fakeData.Order;
        }
    }
}
