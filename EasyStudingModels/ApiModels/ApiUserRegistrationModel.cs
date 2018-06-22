namespace EasyStudingModels.ApiModels
{
    public partial class ApiUserRegistrationModel : IValidatedEntity
    {
        public string TelephoneNumber { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(TelephoneNumber);
        }
    }
}
