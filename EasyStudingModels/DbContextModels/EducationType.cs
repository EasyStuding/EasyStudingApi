namespace EasyStudingModels.DbContextModels
{
    public partial class EducationType: IEntity<EducationType>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public void Edit(EducationType educationType)
        {
            Name = educationType.Name;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(Name);
        }
    }
}
