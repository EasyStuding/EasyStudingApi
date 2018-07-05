using System;

namespace EasyStudingModels.Models
{
    public partial class City: IEntity<City>
    {
        public long Id { get; set; }
        public long RegionId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public void Edit(City city)
        {
            RegionId = city.RegionId;
            Name = city.Name;
            CreationDate = city.CreationDate;
        }

        public bool Validate()
        {
            return Id >= 0
                && RegionId >= 0
                && !string.IsNullOrWhiteSpace(Name)
                && CreationDate != null;
        }
    }
}
