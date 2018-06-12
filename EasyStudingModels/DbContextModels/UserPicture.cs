using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class UserPicture
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public string Ref { get; set; }

        public UserInformation UserInformation { get; set; }
    }
}
