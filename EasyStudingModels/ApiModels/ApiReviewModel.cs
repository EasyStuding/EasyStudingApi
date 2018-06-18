namespace EasyStudingModels.ApiModels
{
    public partial class ApiReviewModel
    {
        public long Id { get; set; }
        public ApiUserDescriptionModel ReviewOwner { get; set; }
        public ApiUserDescriptionModel ReviewRecipient { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Raiting { get; set; }
    }
}
