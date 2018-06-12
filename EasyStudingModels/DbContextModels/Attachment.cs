using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class Attachment
    {
        public Attachment()
        {
            OpenSourceAttachments = new HashSet<OpenSourceAttachment>();
            OrderAttachments = new HashSet<OrderAttachment>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public string Href { get; set; }

        public ICollection<OpenSourceAttachment> OpenSourceAttachments { get; set; }
        public ICollection<OrderAttachment> OrderAttachments { get; set; }
    }
}
