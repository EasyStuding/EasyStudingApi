using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class City
    {
        public City()
        {
            UserDescriptions = new HashSet<UserDescription>();
            Educations = new HashSet<Education>();
        }

        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public ICollection<UserDescription> UserDescriptions { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
