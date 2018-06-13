namespace EasyStudingModels.DbContextModels
{
    public partial class City
    {
        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }
    }
}
