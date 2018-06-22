namespace EasyStudingModels.ApiModels
{
    public class ApiLoginModel : IValidatedEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(Login)
                && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
