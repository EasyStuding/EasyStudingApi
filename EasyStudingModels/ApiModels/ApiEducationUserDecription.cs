using System;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiEducationUserDecription
    {
        public long Id { get; set; }
        public ApiEducation Education { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
