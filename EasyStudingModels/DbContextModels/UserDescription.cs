namespace EasyStudingModels.DbContextModels
{
    public partial class UserDescription
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public long? EducationUserDecriptionId { get; set; }
        public long? EmailDescriptionId { get; set; }
        public long? CityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
    }
}
