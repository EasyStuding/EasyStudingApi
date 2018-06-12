using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            OrderAttachments = new HashSet<OrderAttachment>();
            OrderSkills = new HashSet<OrderSkill>();
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long? ExecutorId { get; set; }
        public long StateId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public UserInformation Customer { get; set; }
        public UserInformation Executor { get; set; }
        public State State { get; set; }
        public ICollection<OrderAttachment> OrderAttachments { get; set; }
        public ICollection<OrderSkill> OrderSkills { get; set; }
    }
}
