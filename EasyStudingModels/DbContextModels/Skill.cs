using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Skill
    {
        public Skill()
        {
            ExecutorSkills = new HashSet<ExecutorSkill>();
            OrderSkills = new HashSet<OrderSkill>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ExecutorSkill> ExecutorSkills { get; set; }
        public ICollection<OrderSkill> OrderSkills { get; set; }
    }
}
