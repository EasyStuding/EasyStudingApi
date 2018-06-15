namespace EasyStudingModels.DbContextModels
{
    public partial class OpenTransaction
    {
        public long Id { get; set; }
        public long OrderDetailsId { get; set; }
        public bool? IsOpenedByCustomer { get; set; }
        public bool? IsOpenedByExecutor { get; set; }
    }
}
