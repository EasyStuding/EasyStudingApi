namespace EasyStudingModels.Models
{
    public partial class Skill: IEntity<Skill>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public void Edit(Skill skill)
        {
            Name = skill.Name;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(Name);
        }
    }
}
