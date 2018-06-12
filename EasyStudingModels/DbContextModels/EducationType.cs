using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class EducationType
    {
        public EducationType()
        {
            Educations = new HashSet<Education>();
        }

        public long Id { get; set; }
        public string TypeName { get; set; }

        public ICollection<Education> Educations { get; set; }
    }
}
