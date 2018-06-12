using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
