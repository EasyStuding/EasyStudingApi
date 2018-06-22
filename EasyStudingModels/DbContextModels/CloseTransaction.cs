namespace EasyStudingModels.DbContextModels
{
    public partial class CloseTransaction: IEntity<CloseTransaction>
    {
        public long Id { get; set; }
        public long OrderDetailsId { get; set; }
        public bool? IsClosedByCustomer { get; set; } = false;
        public bool? IsClosedByExecutor { get; set; } = false;

        public void Edit(CloseTransaction closeTransaction)
        {
            OrderDetailsId = closeTransaction.OrderDetailsId;
            IsClosedByCustomer = closeTransaction.IsClosedByCustomer;
            IsClosedByExecutor = closeTransaction.IsClosedByExecutor;
        }

        public bool Validate()
        {
            return Id >= 0
                && OrderDetailsId >= 0;
        }
    }
}
