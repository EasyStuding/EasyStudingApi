namespace EasyStudingModels.DbContextModels
{
    public partial class CloseTransaction
    {
        public long Id { get; set; }
        public long OrderDetailsId { get; set; }
        public bool? IsClosedByCustomer { get; set; }
        public bool? IsClosedByExecutor { get; set; }
    }
}
