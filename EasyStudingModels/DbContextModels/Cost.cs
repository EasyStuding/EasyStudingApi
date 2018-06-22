namespace EasyStudingModels.DbContextModels
{
    public partial class Cost: IEntity<Cost>
    {
        public long Id { get; set; }
        public decimal Money { get; set; }
        public string Product { get; set; }

        public void Edit(Cost cost)
        {
            Money = cost.Money;
            Product = cost.Product;
        }

        public bool Validate()
        {
            return Id >= 0
                && Money >= 0
                && !string.IsNullOrWhiteSpace(Product);
        }
    }
}
