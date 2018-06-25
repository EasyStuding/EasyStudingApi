using System;
using System.Collections.Generic;

namespace EasyStudingModels.Models
{
    public partial class Review: IEntity<Review>
    {
        public long Id { get; set; }
        public long ReviewOwnerId { get; set; }
        public long ReviewRecipientId { get; set; }
        public long OrderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Raiting { get; set; }

        public void Edit(Review review)
        {
            ReviewOwnerId = review.ReviewOwnerId;
            ReviewRecipientId = review.ReviewRecipientId;
            OrderId = review.OrderId;
            Title = review.Title;
            Description = review.Description;
            Raiting = review.Raiting;
        }

        public bool Validate()
        {
            return Id >= 0
                && ReviewOwnerId >= 0
                && ReviewRecipientId >= 0
                && ReviewOwnerId != ReviewRecipientId
                && OrderId >= 0
                && !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description)
                && Raiting == null ? true : Raiting >= 0;
        }
    }
}
