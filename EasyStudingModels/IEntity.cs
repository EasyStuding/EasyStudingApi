namespace EasyStudingModels
{
    public interface IEntity<T>: IValidatedEntity
        where T: class
    {
        long Id { get; set; }

        void Edit(T entity);
    }
}
