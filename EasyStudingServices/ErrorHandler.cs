using System;

namespace EasyStudingServices
{
    public class ErrorHandler
    {
        public void CheckObjectOfNull<TClass>(TClass value)
            where TClass : class
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void CheckIndexOutOfRangeException<TClass>(TClass responceModel)
            where TClass : class
        {
            if (responceModel == null)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
