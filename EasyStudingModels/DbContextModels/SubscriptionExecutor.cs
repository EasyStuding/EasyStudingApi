using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class SubscriptionExecutor: IEntity<SubscriptionExecutor>, ISubstraction
    {
        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }

        public void Edit(SubscriptionExecutor subscriptionExecutor)
        {
            IsActive = subscriptionExecutor.IsActive;
            CostId = subscriptionExecutor.CostId;
            DateExpires = subscriptionExecutor.DateExpires;
        }
    }
}
