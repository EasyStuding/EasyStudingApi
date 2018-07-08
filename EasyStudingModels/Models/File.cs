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

    public class FileToReturnModel : Attachment
    {

    }
}
