using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class SubscriptionOpenSource
    {
        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }
    }
}
