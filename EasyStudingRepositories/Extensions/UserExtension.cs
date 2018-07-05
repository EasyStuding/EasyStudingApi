using EasyStudingModels.Models;
using System;

namespace EasyStudingRepositories.Extensions
{
    public static class UserExtension
    {
        public static void CheckExecutorSubscription(this User user)
        {
            if (user.SubscriptionExecutorExpiresDate == null
                || user.SubscriptionExecutorExpiresDate <= DateTime.Now)
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
