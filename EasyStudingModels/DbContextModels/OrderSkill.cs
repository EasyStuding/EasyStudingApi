namespace EasyStudingModels.DbContextModels
{
    public partial class OrderSkill: IEntity<OrderSkill>
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long SkillId { get; set; }

        public void Edit(OrderSkill orderSkill)
        {
            OrderId = orderSkill.OrderId;
            SkillId = orderSkill.SkillId;
        }
    }
}
