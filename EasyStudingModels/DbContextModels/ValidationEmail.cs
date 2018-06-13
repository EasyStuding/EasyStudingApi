namespace EasyStudingModels.DbContextModels
{
    public partial class ValidationEmail
    {
        public long Id { get; set; }
        public long EmailDescriptionId { get; set; }
        public string ValidateCode { get; set; }
    }
}
