namespace EasyStudingModels.DbContextModels
{
    public partial class Review: IEntity<Review>
    {
        public long Id { get; set; }
        public long ReviewOwnerId { get; set; }
        public long ReviewRecipientId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Raiting { get; set; }

        public void Edit(Review review)
        {
            ReviewOwnerId = review.ReviewOwnerId;
            ReviewRecipientId = review.ReviewRecipientId;
            Title = review.Title;
            Description = review.Description;
            Raiting = review.Raiting;
        }
    }
}
