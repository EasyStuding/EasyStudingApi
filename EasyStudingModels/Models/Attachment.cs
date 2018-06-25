using System;
using System.Collections.Generic;

namespace EasyStudingModels.Models
{
    public partial class Attachment: IEntity<Attachment>
    {
        public long Id { get; set; }
        public long ContainerId { get; set; }
        public string ContainerName { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }

        public void Edit(Attachment attachment)
        {
            Type = attachment.Type;
            Link = attachment.Link;
        }

        public bool Validate()
        {
            return Id >= 0
                && ContainerId >= 0
                && !string.IsNullOrWhiteSpace(ContainerName)
                && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Link);
        }
    }
}
