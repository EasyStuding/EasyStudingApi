namespace EasyStudingModels.DbContextModels
{
    public partial class Role : IEntity<Role>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public void Edit(Role role)
        {
            Name = role.Name;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(Name);
        }
    }
}
