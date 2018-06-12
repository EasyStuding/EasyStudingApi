using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class OpenSource
    {
        public OpenSource()
        {
            OpenSourceAttachments = new HashSet<OpenSourceAttachment>();
            UserInformations = new HashSet<UserInformation>();
        }

        public long Id { get; set; }
        public long OpenSourceSubscriptionId { get; set; }

        public SubscriptionOpenSource OpenSourceSubscription { get; set; }
        public ICollection<OpenSourceAttachment> OpenSourceAttachments { get; set; }
        public ICollection<UserInformation> UserInformations { get; set; }
    }
}
