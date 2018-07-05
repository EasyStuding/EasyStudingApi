﻿namespace EasyStudingModels.Models
{
    public partial class Order: IEntity<Order>
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long? ExecutorId { get; set; }
        public bool? InProgress { get; set; } = false;
        public bool? IsClosedByCustomer { get; set; } = false;
        public bool? IsClosedByExecutor { get; set; } = false;
        public bool? IsCompleted { get; set; } = false;
        public string Title { get; set; }
        public string Description { get; set; }

        public void Edit(Order order)
        {
            CustomerId = order.CustomerId;
            ExecutorId = order.ExecutorId;
            IsClosedByCustomer = order.IsClosedByCustomer;
            IsClosedByExecutor = order.IsClosedByExecutor;
            IsCompleted = order.IsCompleted;
            Title = order.Title;
            Description = order.Description;
        }

        public bool Validate()
        {
            return Id >= 0
                && CustomerId >= 0
                && ExecutorId >= 0
                && CustomerId != ExecutorId
                && !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description);
        }
    }
}
