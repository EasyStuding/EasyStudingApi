using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingModels.ApiModels
{
    public class ApiRegisrtationLoginModel : IValidatedEntity
    {
        public long UserRegistrationId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public bool Validate()
        {
            return UserRegistrationId >= 0
                && !string.IsNullOrWhiteSpace(Login)
                && !string.IsNullOrWhiteSpace(Password);
        }

    }
}
