namespace EasyStudingModels.Models
{
    public class LoginToken : IValidatedEntity
    {
        public long Id { get; set; }

        public string TelephoneNumber { get; set; }

        public string Role { get; set; }

        public string BearerToken { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(TelephoneNumber)
                && !string.IsNullOrWhiteSpace(Role)
                && !string.IsNullOrWhiteSpace(BearerToken);
        }
    }
}
