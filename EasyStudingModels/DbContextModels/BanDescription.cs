using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class BanDescription
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public DateTime DateExpires { get; set; }
    }
}
