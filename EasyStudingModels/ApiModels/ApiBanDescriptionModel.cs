using System;

namespace EasyStudingModels.ApiModels
{
    public partial class ApiBanDescriptionModel : IValidatedEntity
    {
        public long Id { get; set; }
        public ApiUserDescriptionModel UserDescription { get; set; }
        public DateTime ExpiresDate { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && UserDescription.Validate()
                && ExpiresDate != null;
        }
    }
}
