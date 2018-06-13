namespace EasyStudingModels.DbContextModels
{
    public partial class State
    {
        public long Id { get; set; }
        public bool? InProgress { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
