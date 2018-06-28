using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingModels.Models
{
    public class RestorePasswordModel: IValidatedEntity
    {
        public string TelephoneNumber { get; set; }

        public string ValidationCode { get; set; }

        public string Password { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(TelephoneNumber)
                && !string.IsNullOrWhiteSpace(ValidationCode)
                && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
