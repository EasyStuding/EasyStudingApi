using System;

namespace EasyStudingModels.Models
{
    public partial class Region: IEntity<Region>
    {
        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public void Edit(Region region)
        {
            CountryId = region.CountryId;
            Name = region.Name;
            CreationDate = region.CreationDate;
        }

        public bool Validate()
        {
            return Id >= 0
                && CountryId >= 0
                && !string.IsNullOrWhiteSpace(Name)
                && CreationDate != null;
        }
    }
}
