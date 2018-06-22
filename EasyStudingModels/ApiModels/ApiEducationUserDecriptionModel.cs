using System;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiEducationUserDecriptionModel : IValidatedEntity
    {
        public long Id { get; set; }
        public ApiEducationModel Education { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && Education.Validate()
                && AdmissionDate != null
                && GraduationDate != null;
        }
    }
}
