using System;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiBanDescription
    {
        public long Id { get; set; }
        public ApiUserInformation UserInformation { get; set; }
        public DateTime DateExpires { get; set; }
    }
}
