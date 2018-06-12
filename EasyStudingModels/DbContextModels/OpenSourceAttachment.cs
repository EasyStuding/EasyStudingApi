using System;
using System.Collections.Generic;

namespace EasyStudingModels.DbContextModels
{
    public partial class OpenSourceAttachment
    {
        public long Id { get; set; }
        public long OpenSourceId { get; set; }
        public long AttachmentId { get; set; }

        public Attachment Attachment { get; set; }
        public OpenSource OpenSource { get; set; }
    }
}
