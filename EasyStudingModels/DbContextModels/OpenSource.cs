namespace EasyStudingModels.DbContextModels
{
    public partial class OpenSource: IEntity<OpenSource>
    {
        public long Id { get; set; }
        public long OpenSourceSubscriptionId { get; set; }

        public void Edit(OpenSource openSource)
        {
            OpenSourceSubscriptionId = openSource.OpenSourceSubscriptionId;
        }
    }
}
