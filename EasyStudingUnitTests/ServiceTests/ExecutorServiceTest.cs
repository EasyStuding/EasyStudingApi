using EasyStudingServices.Services;
using EasyStudingUnitTests.TestData;
using System.Linq;
using Xunit;

namespace EasyStudingUnitTests.ServiceTests
{
    public class ExecutorServiceTest
    {
        [Fact(DisplayName = "ExecutorService.GetOrders(valid) should return 5 objects.")]
        public async void ExecutorService_GetOrders_valid_should_return_5_objects()
        {
            var service = new ExecutorService(new TestExecutorRepository());

            var result = await service.GetOrders(null, null, null, null, 2);

            Assert.Equal(5, result.Count());
        }

        [Fact(DisplayName = "ExecutorService.GetOrder(1, 2) should return valid object.")]
        public async void ExecutorService_GetOrder_1_1_should_return_valid_object()
        {
            var service = new ExecutorService(new TestExecutorRepository());

            var result = await service.GetOrder(1, 2);

            Assert.Equal(1, result.Id);
        }
                
        [Fact(DisplayName = "ExecutorService.GetTheRightsToPerformOrder(1, 2) should return valid object.")]
        public async void ExecutorService_GetTheRightsToPerformOrder_1_2_should_return_valid_object()
        {
            var service = new ExecutorService(new TestExecutorRepository());

            var result = await service.GetTheRightsToPerformOrder(1, 2);

            Assert.Equal(2, result.ExecutorId);
        }

        [Fact(DisplayName = "ExecutorService.CloseOrder(1, 2) should return valid object.")]
        public async void ExecutorService_CloseOrder_1_2_should_return_valid_object()
        {
            var service = new ExecutorService(new TestExecutorRepository());

            var result = await service.CloseOrder(1, 2);

            Assert.True(result.IsClosedByExecutor);
        }

        [Fact(DisplayName = "ExecutorService.AddSkill(1, 2) should return valid object.")]
        public async void ExecutorService_AddSkill_1_2_should_return_valid_object()
        {
            var service = new ExecutorService(new TestExecutorRepository());

            var result = await service.AddSkill(1, 2);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "ExecutorService.RemoveSkill(1, 2) should return valid object.")]
        public async void ExecutorService_RemoveSkill_1_2_should_return_valid_object()
        {
            var service = new ExecutorService(new TestExecutorRepository());

            var result = await service.RemoveSkill(1, 2);

            Assert.Equal(1, result.Id);
        }
    }
}
