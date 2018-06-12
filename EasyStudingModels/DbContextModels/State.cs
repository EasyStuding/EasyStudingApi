using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class State
    {
        public State()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public long Id { get; set; }
        public bool? InProgress { get; set; }
        public bool? IsCompleted { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
