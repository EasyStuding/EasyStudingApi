namespace EasyStudingModels.DbContextModels
{
    public partial class OrderSkill
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long SkillId { get; set; }
    }
}
