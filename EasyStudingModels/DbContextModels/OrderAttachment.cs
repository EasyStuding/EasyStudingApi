namespace EasyStudingModels.DbContextModels
{
    public partial class OrderAttachment
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long AttachmentId { get; set; }
    }
}
