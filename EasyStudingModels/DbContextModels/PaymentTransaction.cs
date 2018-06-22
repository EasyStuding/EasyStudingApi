namespace EasyStudingModels.DbContextModels
{
    public partial class PaymentTransaction : IEntity<PaymentTransaction>
    {
        public long Id { get; set; }
        public long CostId { get; set; }
        public long UserinformationId { get; set; }
        public bool? IsPaid { get; set; } = false;

        public void Edit(PaymentTransaction paymentTransaction)
        {
            CostId = paymentTransaction.CostId;
            UserinformationId = paymentTransaction.UserinformationId;
            IsPaid = paymentTransaction.IsPaid;
        }

        public bool Validate()
        {
            return Id >= 0
                && CostId >= 0
                && UserinformationId >= 0;
        }
    }
}
