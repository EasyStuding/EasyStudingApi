﻿namespace EasyStudingModels.DbContextModels
{
    public partial class ExecutorSkill: IEntity<ExecutorSkill>
    {
        public long Id { get; set; }
        public long SubscriptionExecutorId { get; set; }
        public long SkillId { get; set; }

        public void Edit(ExecutorSkill executorSkill)
        {
            SubscriptionExecutorId = executorSkill.SubscriptionExecutorId;
            SkillId = executorSkill.SkillId;
        }
    }
}
