namespace EasyStudingModels.DbContextModels
{
    public partial class ValidationEmail: IEntity<ValidationEmail>
    {
        public long Id { get; set; }
        public long EmailDescriptionId { get; set; }
        public string ValidateCode { get; set; }

        public void Edit(ValidationEmail validationEmail)
        {
            EmailDescriptionId = validationEmail.EmailDescriptionId;
            ValidateCode = validationEmail.ValidateCode;
        }

        public bool Validate()
        {
            return Id >= 0
                && EmailDescriptionId >= 0
                && !string.IsNullOrWhiteSpace(ValidateCode);
        }
    }
}
