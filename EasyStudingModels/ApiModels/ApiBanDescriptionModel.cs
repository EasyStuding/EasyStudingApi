using System;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiBanDescriptionModel
    {
        public long Id { get; set; }
        public ApiUserInformationModel UserInformation { get; set; }
        public DateTime ExpiresDate { get; set; }
    }
}
