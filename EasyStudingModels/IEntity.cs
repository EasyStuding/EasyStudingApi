namespace EasyStudingModels
{
    public interface IEntity<T>
        where T: class
    {
        long Id { get; set; }

        void Edit(T entity);
    }
}
