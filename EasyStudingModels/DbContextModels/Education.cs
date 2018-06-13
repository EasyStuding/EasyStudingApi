namespace EasyStudingModels.DbContextModels
{
    public partial class Education
    {
        public long Id { get; set; }
        public long EducationTypeId { get; set; }
        public string EducationName { get; set; }
        public long CityId { get; set; }
    }
}
