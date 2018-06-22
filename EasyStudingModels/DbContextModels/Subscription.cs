using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingModels.DbContextModels
{
    public partial class Subscription : IEntity<Subscription>
    {
        public long Id { get; set; }
        public bool? IsActive { get; set; } = false;
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }

        public void Edit(Subscription subscription)
        {
            IsActive = subscription.IsActive;
            CostId = subscription.CostId;
            DateExpires = subscription.DateExpires;
        }

        public bool Validate()
        {
            return Id >= 0
                && CostId >= 0
                && DateExpires != null;
        }
    }
}
