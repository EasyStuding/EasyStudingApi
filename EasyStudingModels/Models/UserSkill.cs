using System;
using System.Collections.Generic;

namespace EasyStudingModels.Models
{
    public partial class UserSkill: IEntity<UserSkill>
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SkillId { get; set; }

        public void Edit(UserSkill userSkill)
        {
            UserId = userSkill.UserId;
            SkillId = userSkill.SkillId;
        }

        public bool Validate()
        {
            return Id >= 0
                && UserId >= 0
                && SkillId >= 0;
        }
    }
}
