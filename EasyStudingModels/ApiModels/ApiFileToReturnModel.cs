namespace EasyStudingModels.ApiModels
{
    public class ApiFileToReturnModel : IValidatedEntity
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Ref { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && UserId >= 0
                && !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Ref);
        }
    }
}
