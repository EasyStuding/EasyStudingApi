using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestUserSkillRepository : IRepository<UserSkill>
    {
        private FakeData _fakeData;

        public TestUserSkillRepository()
        {
            _fakeData = new FakeData();
        }
        public async Task<UserSkill> AddAsync(UserSkill param)
        {
            return _fakeData.UserSkill;
        }

        public async Task<UserSkill> EditAsync(UserSkill param)
        {
            return _fakeData.UserSkill;
        }

        public IQueryable<UserSkill> GetAll()
        {
            return _fakeData.UserSkills.AsQueryable();
        }

        public async Task<UserSkill> GetAsync(long id)
        {
            return _fakeData.UserSkill;
        }

        public async Task<UserSkill> RemoveAsync(long id)
        {
            return _fakeData.UserSkill;
        }
    }
}
