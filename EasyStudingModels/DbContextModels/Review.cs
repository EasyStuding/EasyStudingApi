using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Review
    {
        public long Id { get; set; }
        public long UserInformationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Raiting { get; set; }

        public UserInformation UserInformation { get; set; }
    }
}
