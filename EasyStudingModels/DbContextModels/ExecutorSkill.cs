using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class ExecutorSkill
    {
        public long Id { get; set; }
        public long SubscriptionExecutorId { get; set; }
        public long SkillId { get; set; }

        public Skill Skill { get; set; }
        public SubscriptionExecutor SubscriptionExecutor { get; set; }
    }
}
