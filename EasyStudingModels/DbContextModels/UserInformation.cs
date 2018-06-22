namespace EasyStudingModels.DbContextModels
{
    public partial class UserInformation: IEntity<UserInformation>
    {
        public long Id { get; set; }
        public long UserRegistrationId { get; set; }
        public long RoleId { get; set; }
        public long? SubscriptionId { get; set; }
        public long? OpenSourceId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool? IsBanned { get; set; } = false;
        public bool? IsFreeTrial { get; set; } = false;
        public bool? IsGaranted { get; set; } = false;

        public void Edit(UserInformation userInformation)
        {
            UserRegistrationId = userInformation.UserRegistrationId;
            RoleId = userInformation.RoleId;
            SubscriptionId = userInformation.SubscriptionId;
            OpenSourceId = userInformation.OpenSourceId;
            LoginName = userInformation.LoginName;
            Password = userInformation.Password;
            IsBanned = userInformation.IsBanned;
            IsFreeTrial = userInformation.IsFreeTrial;
            IsGaranted = userInformation.IsGaranted;
        }

        public bool Validate()
        {
            return Id >= 0
                && UserRegistrationId >= 0
                && RoleId >= 0
                && SubscriptionId == null ? true : SubscriptionId >= 0
                && OpenSourceId == null ? true : OpenSourceId >= 0
                && !string.IsNullOrWhiteSpace(LoginName)
                && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
