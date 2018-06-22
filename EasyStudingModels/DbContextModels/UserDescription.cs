namespace EasyStudingModels.DbContextModels
{
    public partial class UserDescription: IEntity<UserDescription>
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public long? EducationUserDecriptionId { get; set; }
        public long? EmailDescriptionId { get; set; }
        public long? CityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        public void Edit(UserDescription userDescription)
        {
            UserInformationId = userDescription.UserInformationId;
            EducationUserDecriptionId = userDescription.EducationUserDecriptionId;
            EmailDescriptionId = userDescription.EmailDescriptionId;
            CityId = userDescription.CityId;
            FirstName = userDescription.FirstName;
            LastName = userDescription.LastName;
            Description = userDescription.Description;
        }

        public bool Validate()
        {
            return Id >= 0
                && UserInformationId >= 0
                && EducationUserDecriptionId == null ? true : EducationUserDecriptionId >= 0
                && EmailDescriptionId == null ? true : EmailDescriptionId >= 0
                && CityId == null ? true : CityId >= 0
                && FirstName == null ? true : !string.IsNullOrWhiteSpace(FirstName)
                && LastName == null ? true : !string.IsNullOrWhiteSpace(LastName)
                && Description == null ? true : !string.IsNullOrWhiteSpace(Description);
        }
    }
}
