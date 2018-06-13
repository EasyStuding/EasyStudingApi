using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class UserRegistration
    {
        public long Id { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool? IsValidated { get; set; }
    }
}
