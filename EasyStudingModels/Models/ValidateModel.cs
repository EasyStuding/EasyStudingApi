namespace EasyStudingModels.Models
{
    public class ValidateModel: IValidatedEntity
    {
        public long UserId { get; set; }
        public string ValidationCode { get; set; }

        public bool Validate()
        {
            return UserId >= 0
                && !string.IsNullOrWhiteSpace(ValidationCode);
        }
    }
}
