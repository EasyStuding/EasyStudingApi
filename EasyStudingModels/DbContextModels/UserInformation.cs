namespace EasyStudingModels.DbContextModels
{
    public partial class UserInformation
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
    }
}
