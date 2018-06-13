using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class SubscriptionExecutor
    {
        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }
    }
}
