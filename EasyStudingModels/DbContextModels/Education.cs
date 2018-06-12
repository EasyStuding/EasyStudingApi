using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Education
    {
        public Education()
        {
            EducationUserDecriptions = new HashSet<EducationUserDecription>();
        }

        public long Id { get; set; }
        public long EducationtypeId { get; set; }
        public string Nameofeducation { get; set; }
        public long CityId { get; set; }

        public EducationType EducationType { get; set; }
        public City City { get; set; }
        public ICollection<EducationUserDecription> EducationUserDecriptions { get; set; }
    }
}
