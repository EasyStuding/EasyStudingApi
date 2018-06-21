namespace EasyStudingModels.DbContextModels
{
    public partial class Skill: IEntity<Skill>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public void Edit(Skill skill)
        {
            Name = skill.Name;
        }
    }
}
