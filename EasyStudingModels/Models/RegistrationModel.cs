namespace EasyStudingModels.Models
{
    public class RegistrationModel: IValidatedEntity
    {
        public string TelephoneNumber { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(TelephoneNumber);
        }
    }
}
