using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Cost
    {
        public Cost()
        {
            PaymentTransactions = new HashSet<PaymentTransaction>();
            SubscriptionExecutors = new HashSet<SubscriptionExecutor>();
            SubscriptionOpenSources = new HashSet<SubscriptionOpenSource>();
        }

        public long Id { get; set; }
        public decimal Money { get; set; }
        public string Product { get; set; }

        public ICollection<PaymentTransaction> PaymentTransactions { get; set; }
        public ICollection<SubscriptionExecutor> SubscriptionExecutors { get; set; }
        public ICollection<SubscriptionOpenSource> SubscriptionOpenSources { get; set; }
    }
}
