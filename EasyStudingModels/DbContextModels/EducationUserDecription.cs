using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class EducationUserDecription
    {
        public EducationUserDecription()
        {
            UserDescriptions = new HashSet<UserDescription>();
        }

        public long Id { get; set; }
        public long EducationId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Education Education { get; set; }
        public ICollection<UserDescription> UserDescriptions { get; set; }
    }
}
