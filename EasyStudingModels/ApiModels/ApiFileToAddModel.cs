namespace EasyStudingModels.ApiModels
{
    public class ApiFileToAddModel : IValidatedEntity
    {
        public long UserId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Data { get; set; }

        public bool Validate()
        {
            return UserId >= 0
                && !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Data);
        }
    }
}
