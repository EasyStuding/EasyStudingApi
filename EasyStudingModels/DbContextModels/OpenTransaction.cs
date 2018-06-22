namespace EasyStudingModels.DbContextModels
{
    public partial class OpenTransaction: IEntity<OpenTransaction>
    {
        public long Id { get; set; }
        public long OrderDetailsId { get; set; }
        public bool? IsOpenedByCustomer { get; set; } = false;
        public bool? IsOpenedByExecutor { get; set; } = false;

        public void Edit(OpenTransaction openTransaction)
        {
            OrderDetailsId = openTransaction.OrderDetailsId;
            IsOpenedByCustomer = openTransaction.IsOpenedByCustomer;
            IsOpenedByExecutor = openTransaction.IsOpenedByExecutor;
        }

        public bool Validate()
        {
            return Id >= 0
                && OrderDetailsId >= 0;
        }
    }
}
