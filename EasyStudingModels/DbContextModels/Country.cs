namespace EasyStudingModels.DbContextModels
{
    public partial class Country: IEntity<Country>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public void Edit(Country country)
        {
            Name = country.Name;
        }
    }
}
