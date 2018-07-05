using EasyStudingServices.Services;
using EasyStudingUnitTests.TestData;
using System.Linq;
using Xunit;

namespace EasyStudingUnitTests.ServiceTests
{
    public class ModeratorServiceTest
    {
        [Fact(DisplayName = "ModeratorService.BanUser(1) should return object with id 1.")]
        public async void ModeratorService_BanUser_1_should_return_object_1()
        {
            var service = new ModeratorService(new TestModeratorRepository());

            var result = await service.BanUser(1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "ModeratorService.RemoveBanOfUser(1) should return object with id 1.")]
        public async void ModeratorService_RemoveBanOfUser_1_should_return_object_1()
        {
            var service = new ModeratorService(new TestModeratorRepository());

            var result = await service.RemoveBanOfUser(1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "ModeratorService.CloseOrder(1) should return object with id 1.")]
        public async void ModeratorService_CloseOrder_1_should_return_object_1()
        {
            var service = new ModeratorService(new TestModeratorRepository());

            var result = await service.CloseOrder(1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "ModeratorService.GetOrders() should return 5 objects.")]
        public async void ModeratorService_GetOrders_should_return_5_objects()
        {
            var service = new ModeratorService(new TestModeratorRepository());

            var result = service.GetOrders(null, null, null, null);

            Assert.Equal(5, result.Count());
        }

        [Fact(DisplayName = "ModeratorService.GetOrder(1) should return object with id 1.")]
        public async void ModeratorService_GetOrder_1_should_return_object_1()
        {
            var service = new ModeratorService(new TestModeratorRepository());

            var result = await service.GetOrder(1);

            Assert.Equal(1, result.Id);
        }
    }
}
