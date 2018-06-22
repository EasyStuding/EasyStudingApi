namespace EasyStudingModels.DbContextModels
{
    public partial class Education: IEntity<Education>
    {
        public long Id { get; set; }
        public long EducationTypeId { get; set; }
        public long CityId { get; set; }
        public string EducationName { get; set; }

        public void Edit(Education education)
        {
            EducationTypeId = education.EducationTypeId;
            CityId = education.CityId;
            EducationName = education.EducationName;
        }

        public bool Validate()
        {
            return Id >= 0
                && EducationTypeId >= 0
                && CityId >= 0
                && !string.IsNullOrWhiteSpace(EducationName);
        }
    }
}
