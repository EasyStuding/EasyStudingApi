using EasyStudingModels.Extensions;

namespace EasyStudingModels.Models
{
    public class LoginModel: IValidatedEntity
    {
        public string TelephoneNumber { get; set; }
        public string Password { get; set; }

        public bool Validate()
        {
            return TelephoneNumber.IsValidTelephoneNumber()
                && Password.IsValidPassword();
        }
    }
}
