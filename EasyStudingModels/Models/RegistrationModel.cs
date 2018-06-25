using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingModels.Models
{
    public class RegistrationModel: IValidatedEntity
    {
        public string TelephoneNumber { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(TelephoneNumber);
        }
    }
}
