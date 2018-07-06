using EasyStudingModels.Extensions;

namespace EasyStudingModels.Models
{
    public partial class Attachment: IEntity<Attachment>
    {
        public long Id { get; set; }
        public long ContainerId { get; set; } //User or order id.
        public string ContainerName { get; set; } // User or order in defines.
        public string Name { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }

        public void Edit(Attachment attachment)
        {
            Name = attachment.Name;
            Type = attachment.Type;
            Link = attachment.Link;
        }

        public bool Validate()
        {
            return Id >= 0
                && ContainerId >= 0
                && ContainerName.IsValidContainerName()
                && !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Link);
        }
    }
}
