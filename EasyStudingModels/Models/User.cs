using System;
using System.Collections.Generic;
using static EasyStudingModels.Defines;

namespace EasyStudingModels.Models
{
    public partial class User: IEntity<User>
    {
        public long Id { get; set; }

        public string TelephoneNumber { get; set; }
        public bool? TelephoneNumberIsValidated { get; set; } = false;
        
        public string Email { get; set; }
        public bool? EmailIsValidated { get; set; } = false;
        
        public string FullName { get; set; }
        public string Description { get; set; }
        public string PictureLink { get; set; }
        public string Role { get; set; } = Roles.USER;

        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Education { get; set; }

        public bool? UserIsGaranted { get; set; } = false;
        public decimal? Raiting { get; set; } = 0;

        public DateTime? RegistrationDate { get; set; } = DateTime.Now;
        public DateTime? BanExpiresDate { get; set; } = DateTime.Now;
        public DateTime? SubscriptionExecutorExpiresDate { get; set; } = DateTime.Now;
        public DateTime? SubscriptionOpenSourceExpiresDate { get; set; } = DateTime.Now;

        public void Edit(User user)
        {
            RegistrationDate = user.RegistrationDate;
            Role = user.Role;
            BanExpiresDate = user.BanExpiresDate;
            Education = user.Education;
            SubscriptionExecutorExpiresDate = user.SubscriptionExecutorExpiresDate;
            SubscriptionOpenSourceExpiresDate = user.SubscriptionOpenSourceExpiresDate;
            FullName = user.FullName;
            Description = user.Description;
            PictureLink = user.PictureLink;
            UserIsGaranted = user.UserIsGaranted;
            Raiting = user.Raiting;

            Email = user.Email;
            EmailIsValidated = user.EmailIsValidated;

            TelephoneNumber = user.TelephoneNumber;
            TelephoneNumberIsValidated = user.TelephoneNumberIsValidated;

            Country = user.Country;
            Region = user.Region;
            City = user.City;
        }

        public bool Validate()
        {
            return Id >= 0
                && !string.IsNullOrWhiteSpace(TelephoneNumber)
                && RegistrationDate != null
                && !string.IsNullOrWhiteSpace(Role)
                && BanExpiresDate != null
                && !string.IsNullOrWhiteSpace(Education)
                && SubscriptionExecutorExpiresDate != null
                && SubscriptionOpenSourceExpiresDate != null
                && !string.IsNullOrWhiteSpace(FullName)
                && !string.IsNullOrWhiteSpace(Description)
                && !string.IsNullOrWhiteSpace(PictureLink)
                && !string.IsNullOrWhiteSpace(Email)
                && !string.IsNullOrWhiteSpace(Country)
                && !string.IsNullOrWhiteSpace(Region)
                && !string.IsNullOrWhiteSpace(City)
                && Raiting == null ? true : Raiting >= 0;
        }
    }
}
