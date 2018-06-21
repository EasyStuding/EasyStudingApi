using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class SubscriptionOpenSource: IEntity<SubscriptionOpenSource>
    {
        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }

        public void Edit(SubscriptionOpenSource subscriptionOpenSource)
        {
            IsActive = subscriptionOpenSource.IsActive;
            CostId = subscriptionOpenSource.CostId;
            DateExpires = subscriptionOpenSource.DateExpires;
        }
    }
}
