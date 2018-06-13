using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class EducationUserDecription
    {
        public long Id { get; set; }
        public long EducationId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
