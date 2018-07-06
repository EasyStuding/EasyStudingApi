using EasyStudingModels.Extensions;

namespace EasyStudingModels.Models
{
    public class RestorePasswordModel: IValidatedEntity
    {
        public string TelephoneNumber { get; set; }

        public string ValidationCode { get; set; }

        public string Password { get; set; }

        public bool Validate()
        {
            return TelephoneNumber.IsValidTelephoneNumber()
                && !string.IsNullOrWhiteSpace(ValidationCode)
                && Password.IsValidPassword();
        }
    }
}
