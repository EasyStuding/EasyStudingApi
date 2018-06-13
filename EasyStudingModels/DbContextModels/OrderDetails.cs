namespace EasyStudingModels.DbContextModels
{
    public partial class OrderDetails
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long? ExecutorId { get; set; }
        public long StateId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
