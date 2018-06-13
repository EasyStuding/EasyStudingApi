using EasyStudingModels.DbContextModels;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiEducation
    {
        public long Id { get; set; }
        public EducationType Educationtype { get; set; }
        public string Nameofeducation { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
    }
}
