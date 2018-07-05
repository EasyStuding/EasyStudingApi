namespace EasyStudingModels.Models
{
    public class LoginToken : IValidatedEntity
    {
        public User User { get; set; }

        public string BearerToken { get; set; }

        public bool Validate()
        {
            return User.Validate()
                && !string.IsNullOrWhiteSpace(BearerToken);
        }
    }
}
