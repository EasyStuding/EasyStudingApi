using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class ValidationUser
    {
        public long Id { get; set; }
        public long UserRegistrationId { get; set; }
        public string ValidationCode { get; set; }

        public UserRegistration UserRegistration { get; set; }
    }
}
