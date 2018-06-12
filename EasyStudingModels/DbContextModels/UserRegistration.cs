using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class UserRegistration
    {
        public UserRegistration()
        {
            UserInformations = new HashSet<UserInformation>();
            ValidationUsers = new HashSet<ValidationUser>();
        }

        public long Id { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool? IsValidated { get; set; }

        public ICollection<UserInformation> UserInformations { get; set; }
        public ICollection<ValidationUser> ValidationUsers { get; set; }
    }
}
