namespace EasyStudingModels.DbContextModels
{
    public partial class UserInformation: IEntity<UserInformation>
    {
        public long Id { get; set; }
        public long UserRegistrationId { get; set; }
        public long RoleId { get; set; }
        public long? SubscriptionExecutorId { get; set; }
        public long? OpenSourceId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool? IsBanned { get; set; }
        public bool? IsFreeTrial { get; set; }
        public bool? IsGaranted { get; set; }

        public void Edit(UserInformation userInformation)
        {
            UserRegistrationId = userInformation.UserRegistrationId;
            RoleId = userInformation.RoleId;
            SubscriptionExecutorId = userInformation.SubscriptionExecutorId;
            OpenSourceId = userInformation.OpenSourceId;
            LoginName = userInformation.LoginName;
            Password = userInformation.Password;
            IsBanned = userInformation.IsBanned;
            IsFreeTrial = userInformation.IsFreeTrial;
            IsGaranted = userInformation.IsGaranted;
        }
    }
}
