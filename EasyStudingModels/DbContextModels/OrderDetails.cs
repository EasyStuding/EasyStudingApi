namespace EasyStudingModels.DbContextModels
{
    public partial class OrderDetails: IEntity<OrderDetails>
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long? ExecutorId { get; set; }
        public long StateId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Edit(OrderDetails orderDetails)
        {
            CustomerId = orderDetails.CustomerId;
            ExecutorId = orderDetails.ExecutorId;
            StateId = orderDetails.StateId;
            Title = orderDetails.Title;
            Description = orderDetails.Description;
        }
    }
}
