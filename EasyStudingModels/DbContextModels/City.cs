namespace EasyStudingModels.DbContextModels
{
    public partial class City : IEntity<City>
    {
        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }

        public void Edit(City city)
        {
            CountryId = city.CountryId;
            Region = city.Region;
            Name = city.Name;
        }
    }
}
