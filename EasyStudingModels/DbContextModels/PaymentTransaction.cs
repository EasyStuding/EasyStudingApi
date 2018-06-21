namespace EasyStudingModels.DbContextModels
{
    public partial class PaymentTransaction : IEntity<PaymentTransaction>
    {
        public long Id { get; set; }
        public long CostId { get; set; }
        public long UserinformationId { get; set; }
        public bool? IsPaid { get; set; }

        public void Edit(PaymentTransaction paymentTransaction)
        {
            CostId = paymentTransaction.CostId;
            UserinformationId = paymentTransaction.UserinformationId;
            IsPaid = paymentTransaction.IsPaid;
        }
    }
}
