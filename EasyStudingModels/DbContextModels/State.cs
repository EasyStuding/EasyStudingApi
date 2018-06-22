namespace EasyStudingModels.DbContextModels
{
    public partial class State: IEntity<State>
    {
        public long Id { get; set; }
        public bool? InProgress { get; set; } = false;
        public bool? IsCompleted { get; set; } = false;

        public void Edit(State state)
        {
            InProgress = state.InProgress;
            IsCompleted = state.IsCompleted;
        }

        public bool Validate()
        {
            return Id >= 0;
        }
    }
}
