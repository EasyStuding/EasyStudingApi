namespace EasyStudingModels.DbContextModels
{
    public partial class Education
    {
        public long Id { get; set; }
        public long EducationtypeId { get; set; }
        public string Nameofeducation { get; set; }
        public long CityId { get; set; }
    }
}
