using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class EducationUserDescription
    {
        public long Id { get; set; }
        public long EducationId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
