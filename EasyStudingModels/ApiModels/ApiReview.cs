namespace EasyStudingModels.ApiModels
{
    public partial class ApiReview
    {
        public long Id { get; set; }
        public ApiUserInformation UserInformation { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Raiting { get; set; }
    }
}
