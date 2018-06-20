namespace EasyStudingInterfaces.Services
{
    public interface IErrorHandler
    {
        void CheckObjectOfNull<TClass>(TClass value)
            where TClass : class;

        void CheckIndexOutOfRangeException<TClass>(TClass responceModel)
            where TClass : class;
    }
}
