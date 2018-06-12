using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class SubscriptionExecutor
    {
        public SubscriptionExecutor()
        {
            ExecutorSkills = new HashSet<ExecutorSkill>();
            UserInformations = new HashSet<UserInformation>();
        }

        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long CostId { get; set; }
        public DateTime DateExpires { get; set; }

        public Cost Cost { get; set; }
        public ICollection<ExecutorSkill> ExecutorSkills { get; set; }
        public ICollection<UserInformation> UserInformations { get; set; }
    }
}
