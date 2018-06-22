namespace EasyStudingModels.DbContextModels
{
    public partial class OpenSource: IEntity<OpenSource>
    {
        public long Id { get; set; }
        public long SubscriptionId { get; set; }

        public void Edit(OpenSource openSource)
        {
            SubscriptionId = openSource.SubscriptionId;
        }

        public bool Validate()
        {
            return Id >= 0
                && SubscriptionId >= 0;
        }
    }
}
