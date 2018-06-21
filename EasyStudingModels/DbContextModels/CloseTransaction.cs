namespace EasyStudingModels.DbContextModels
{
    public partial class CloseTransaction: IEntity<CloseTransaction>
    {
        public long Id { get; set; }
        public long OrderDetailsId { get; set; }
        public bool? IsClosedByCustomer { get; set; }
        public bool? IsClosedByExecutor { get; set; }

        public void Edit(CloseTransaction closeTransaction)
        {
            OrderDetailsId = closeTransaction.OrderDetailsId;
            IsClosedByCustomer = closeTransaction.IsClosedByCustomer;
            IsClosedByExecutor = closeTransaction.IsClosedByExecutor;
        }
    }
}
