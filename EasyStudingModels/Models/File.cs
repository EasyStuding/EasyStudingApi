using EasyStudingModels.Extensions;

namespace EasyStudingModels.Models
{
    public class FileToAddModel : IValidatedEntity
    {
        public long ContainerId { get; set; }

        public string ContainerName { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Data { get; set; }

        public bool Validate()
        {
            return ContainerId >= 0
                && ContainerName.IsValidContainerName()
                && !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Data);
        }
    }

    public class FileToReturnModel : IValidatedEntity
    {
        public long Id { get; set; }

        public long ContainerId { get; set; }

        public string ContainerName { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Ref { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && ContainerId >= 0
                && ContainerName.IsValidContainerName()
                && !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Ref);
        }
    }
}
