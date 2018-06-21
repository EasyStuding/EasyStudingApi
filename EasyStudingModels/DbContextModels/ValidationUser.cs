namespace EasyStudingModels.DbContextModels
{
    public partial class ValidationUser: IEntity<ValidationUser>
    {
        public long Id { get; set; }
        public long UserRegistrationId { get; set; }
        public string ValidationCode { get; set; }

        public void Edit(ValidationUser validationUser)
        {
            UserRegistrationId = validationUser.UserRegistrationId;
            ValidationCode = validationUser.ValidationCode;
        }
    }
}
