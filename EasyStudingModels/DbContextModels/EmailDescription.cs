using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class EmailDescription
    {
        public EmailDescription()
        {
            UserDescriptions = new HashSet<UserDescription>();
            ValidationEmails = new HashSet<ValidationEmail>();
        }

        public long Id { get; set; }
        public string Email { get; set; }
        public bool? IsValidated { get; set; }

        public ICollection<UserDescription> UserDescriptions { get; set; }
        public ICollection<ValidationEmail> ValidationEmails { get; set; }
    }
}
