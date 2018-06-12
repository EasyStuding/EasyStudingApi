using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class OrderSkill
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long SkillId { get; set; }

        public OrderDetails Order { get; set; }
        public Skill Skill { get; set; }
    }
}
