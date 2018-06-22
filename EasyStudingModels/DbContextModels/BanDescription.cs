using System;

namespace EasyStudingModels.DbContextModels
{
    public partial class BanDescription: IEntity<BanDescription>
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public DateTime ExpiresDate { get; set; }

        public void Edit(BanDescription banDescription)
        {
            UserInformationId = banDescription.UserInformationId;
            ExpiresDate = ExpiresDate.Date;
        }

        public bool Validate()
        {
            return Id >= 0
                && UserInformationId >= 0
                && ExpiresDate != null;
        }
    }
}
