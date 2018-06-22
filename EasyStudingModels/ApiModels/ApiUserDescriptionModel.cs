using EasyStudingModels.DbContextModels;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiUserDescriptionModel : IValidatedEntity
    {
        public long Id { get; set; }
        public ApiUserInformationModel UserInformation { get; set; }
        public ApiEducationUserDecriptionModel EducationUserDecription { get; set; }
        public EmailDescription EmailDescription { get; set; }
        public UserPicture Picture { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && UserInformation.Validate()
                && EducationUserDecription.Validate()
                && EmailDescription.Validate()
                && Picture.Validate()
                && City.Validate()
                && Country.Validate()
                && !string.IsNullOrWhiteSpace(FirstName)
                && !string.IsNullOrWhiteSpace(LastName)
                && !string.IsNullOrWhiteSpace(Description);
        }
    }
}
