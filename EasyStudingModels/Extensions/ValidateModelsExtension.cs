using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingModels.Extensions
{
    public static class ValidateModelsExtension
    {
        public static void CheckArgumentException(this IValidatedEntity entity)
        {
            if (entity == null
                || !entity?.Validate() == true)
            {
                throw new ArgumentException();
            }
        }
    }
}
