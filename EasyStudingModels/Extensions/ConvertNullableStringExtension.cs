namespace EasyStudingModels.Extensions
{
    public static class ConvertNullableStringExtension
    {
        public static string ConvertToValidModel(this string str)
        {
            return string.IsNullOrWhiteSpace(str)
                ? ""
                : str;
        }
    }
}
