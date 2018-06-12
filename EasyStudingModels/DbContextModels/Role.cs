using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Role
    {
        public Role()
        {
            UserInformation = new HashSet<UserInformation>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserInformation> UserInformation { get; set; }
    }
}
