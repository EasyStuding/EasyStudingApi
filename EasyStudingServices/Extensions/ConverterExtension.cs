using EasyStudingInterfaces.Repositories;
using EasyStudingModels;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace EasyStudingServices.Extensions
{
    public static class ConverterExtension
    {
        public static IEnumerable<Skill> GetSkillsToOrder(this Order order
            , EasyStudingContext context)
        {
            return context.OrderSkills
                .Where(os => os.OrderId == order.Id)
                .Join(
                    context.Skills,
                    os => os.SkillId,
                    s => s.Id,
                    (os, s) => s
                );
        }

        public static IEnumerable<FileToReturnModel> GetAttachmentsToOrder(this Order order
            , IRepository<Attachment> attachmentRepository)
        {
            return attachmentRepository
                    .GetAll()
                    .Where(a => a.ContainerId == order.Id
                        && a.ContainerName == Defines.AttachmentContainerName.ORDER)
                    .Select(a => new FileToReturnModel
                    {
                        Id = a.Id,
                        ContainerId = a.ContainerId,
                        ContainerName = a.ContainerName,
                        Link = a.Link,
                        Name = a.Name,
                        Type = a.Type
                    })
                    .AsEnumerable();
        }

        public static OrderToReturn ConvertOrderToReturn(this Order order
            , IEnumerable<FileToReturnModel> attachments
            , IEnumerable<Skill> skills)
        {
            return new OrderToReturn
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                Description = order.Description,
                ExecutorId = order.ExecutorId,
                InProgress = order.InProgress,
                IsClosedByCustomer = order.IsClosedByCustomer,
                IsClosedByExecutor = order.IsClosedByExecutor,
                IsCompleted = order.IsCompleted,
                Title = order.Title,
                Attachments = attachments,
                Skills = skills
            };
        }

        public static User GetSkillsToUser(this User user,
            EasyStudingContext context)
        {
            user.Skills = context.UserSkills
                .Where(us => us.UserId == user.Id)
                .Join(
                    context.Skills,
                    us => us.SkillId,
                    s => s.Id,
                    (us, s) => s
                );

            return user;
        }
    }
}
