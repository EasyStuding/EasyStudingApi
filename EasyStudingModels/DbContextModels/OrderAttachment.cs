using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class OrderAttachment
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long AttachmentId { get; set; }

        public Attachment Attachment { get; set; }
        public OrderDetails Order { get; set; }
    }
}
