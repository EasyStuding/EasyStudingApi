using System;

namespace EasyStudingModels.Models
{
    public partial class Country: IEntity<Country>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public void Edit(Country country)
        {
            Name = country.Name;
            CreationDate = country.CreationDate;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(Name)
                && CreationDate != null;
        }
    }
}
