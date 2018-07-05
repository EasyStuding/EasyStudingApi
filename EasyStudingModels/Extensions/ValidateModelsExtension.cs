using System;

namespace EasyStudingModels.Extensions
{
    public static class ValidateModelsExtension
    {
        public static void CheckArgumentException(this IValidatedEntity entity)
        {
            if (entity == null
                || !entity.Validate())
            {
                throw new ArgumentException();
            }
        }
    }
}
