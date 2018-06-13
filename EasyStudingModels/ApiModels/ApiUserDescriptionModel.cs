using EasyStudingModels.DbContextModels;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiUserDescriptionModel
    {
        public long Id { get; set; }
        public ApiUserInformationModel UserInformation { get; set; }
        public ApiEducationUserDecriptionModel EducationUserDecription { get; set; }
        public EmailDescription EmailDescription { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
    }
}
