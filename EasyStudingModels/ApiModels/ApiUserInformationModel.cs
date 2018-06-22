namespace EasyStudingModels.ApiModels
{
    public partial class ApiUserInformationModel : IValidatedEntity
    {
        public long Id { get; set; }
        public string TelephoneNumber { get; set; }
        public string Role { get; set; }
        public string LoginName { get; set; }
        public bool? IsBanned { get; set; }
        public bool? IsGaranted { get; set; }
        public bool? IsSubscribedExecutor { get; set; }
        public bool? IsSubscribedOpenSource { get; set; }
        public bool? IsFreeTrial { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(TelephoneNumber)
                && !string.IsNullOrWhiteSpace(Role)
                && !string.IsNullOrWhiteSpace(LoginName);
        }
    }
}
