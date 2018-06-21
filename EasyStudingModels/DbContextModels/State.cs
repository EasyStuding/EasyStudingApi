namespace EasyStudingModels.DbContextModels
{
    public partial class State: IEntity<State>
    {
        public long Id { get; set; }
        public bool? InProgress { get; set; }
        public bool? IsCompleted { get; set; }

        public void Edit(State state)
        {
            InProgress = state.InProgress;
            IsCompleted = state.IsCompleted;
        }
    }
}
