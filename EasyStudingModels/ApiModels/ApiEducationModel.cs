using EasyStudingModels.DbContextModels;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiEducationModel : IValidatedEntity
    {
        public long Id { get; set; }
        public EducationType Educationtype { get; set; }
        public string EducationName { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && Educationtype.Validate()
                && !string.IsNullOrWhiteSpace(EducationName)
                && City.Validate()
                && Country.Validate();
        }
    }
}
