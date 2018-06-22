using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class UserRegistration: IEntity<UserRegistration>
    {
        public long Id { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool? IsValidated { get; set; }

        public void Edit(UserRegistration userRegistration)
        {
            TelephoneNumber = userRegistration.TelephoneNumber;
            RegistrationDate = userRegistration.RegistrationDate;
            IsValidated = userRegistration.IsValidated;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(TelephoneNumber)
                && RegistrationDate != null;
        }
    }
}
