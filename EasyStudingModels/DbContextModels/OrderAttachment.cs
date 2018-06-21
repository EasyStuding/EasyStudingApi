namespace EasyStudingModels.DbContextModels
{
    public partial class OrderAttachment: IEntity<OrderAttachment>
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long AttachmentId { get; set; }

        public void Edit(OrderAttachment orderAttachment)
        {
            OrderId = orderAttachment.OrderId;
            AttachmentId = orderAttachment.AttachmentId;
        }
    }
}
