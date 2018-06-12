using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class BanDescription
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public DateTime DateExpires { get; set; }

        public UserInformation UserInformation { get; set; }
    }
}
