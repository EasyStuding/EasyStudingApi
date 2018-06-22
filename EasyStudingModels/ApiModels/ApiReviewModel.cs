namespace EasyStudingModels.ApiModels
{
    public partial class ApiReviewModel : IValidatedEntity
    {
        public long Id { get; set; }
        public ApiUserDescriptionModel ReviewOwner { get; set; }
        public ApiUserDescriptionModel ReviewRecipient { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Raiting { get; set; }

        public bool Validate()
        {
            return Id >= 0
                && ReviewOwner.Validate()
                && ReviewRecipient.Validate()
                && !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description)
                && Raiting == null ? true : Raiting >= 0;
        }
    }
}
