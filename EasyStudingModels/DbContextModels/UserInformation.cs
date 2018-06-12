using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class UserInformation
    {
        public UserInformation()
        {
            BanDescriptions = new HashSet<BanDescription>();
            OrderDetailsCustomers = new HashSet<OrderDetails>();
            OrderDetailsExecutors = new HashSet<OrderDetails>();
            PaymentTransactions = new HashSet<PaymentTransaction>();
            Reviews = new HashSet<Review>();
            UserDescriptions = new HashSet<UserDescription>();
            UserPictures = new HashSet<UserPicture>();
        }

        public long Id { get; set; }
        public long UserRegistrationId { get; set; }
        public long RoleId { get; set; }
        public long? SubscriptionExecutorId { get; set; }
        public long? OpenSourceId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool? IsBanned { get; set; }
        public bool? IsFreeTrial { get; set; }
        public bool? IsGaranted { get; set; }

        public OpenSource OpenSource { get; set; }
        public Role Role { get; set; }
        public SubscriptionExecutor SubscriptionExecutor { get; set; }
        public UserRegistration UserRegistration { get; set; }
        public ICollection<BanDescription> BanDescriptions { get; set; }
        public ICollection<OrderDetails> OrderDetailsCustomers { get; set; }
        public ICollection<OrderDetails> OrderDetailsExecutors { get; set; }
        public ICollection<PaymentTransaction> PaymentTransactions { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<UserDescription> UserDescriptions { get; set; }
        public ICollection<UserPicture> UserPictures { get; set; }
    }
}
