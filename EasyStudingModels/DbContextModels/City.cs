namespace EasyStudingModels.DbContextModels
{
    public partial class City : IEntity
    {
        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }
    }
}
