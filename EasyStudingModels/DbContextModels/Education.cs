namespace EasyStudingModels.DbContextModels
{
    public partial class Education: IEntity<Education>
    {
        public long Id { get; set; }
        public long EducationTypeId { get; set; }
        public string EducationName { get; set; }
        public long CityId { get; set; }

        public void Edit(Education education)
        {
            EducationTypeId = education.EducationTypeId;
            EducationName = education.EducationName;
            CityId = education.CityId;
        }
    }
}
