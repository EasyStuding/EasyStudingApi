using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class SubscriptionOpenSource
    {
        public SubscriptionOpenSource()
        {
            OpenSource = new HashSet<OpenSource>();
        }

        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }

        public Cost Cost { get; set; }
        public ICollection<OpenSource> OpenSource { get; set; }
    }
}
