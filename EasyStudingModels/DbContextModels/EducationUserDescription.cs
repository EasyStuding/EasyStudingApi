using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class EducationUserDescription: IEntity<EducationUserDescription>
    {
        public long Id { get; set; }
        public long EducationId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public void Edit(EducationUserDescription educationUserDescription)
        {
            EducationId = educationUserDescription.EducationId;
            AdmissionDate = educationUserDescription.AdmissionDate;
            GraduationDate = educationUserDescription.GraduationDate;
        }

        public bool Validate()
        {
            return Id >= 0
                && EducationId >= 0
                && AdmissionDate != null
                && GraduationDate != null;
        }
    }
}
