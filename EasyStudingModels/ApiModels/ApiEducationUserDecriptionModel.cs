using System;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiEducationUserDecriptionModel
    {
        public long Id { get; set; }
        public ApiEducationModel Education { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
