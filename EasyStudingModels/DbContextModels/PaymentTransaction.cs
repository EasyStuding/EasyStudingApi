using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class PaymentTransaction
    {
        public long Id { get; set; }
        public long CostId { get; set; }
        public long UserinformationId { get; set; }
        public bool? IsPaid { get; set; }

        public Cost Cost { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
