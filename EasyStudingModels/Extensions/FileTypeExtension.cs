using Microsoft.AspNetCore.StaticFiles;

namespace EasyStudingModels.Extensions
{
    public static class FileTypeExtension
    {
        public static string GetContentType(this string path)
        {
            new FileExtensionContentTypeProvider()
                .TryGetContentType(path, out string contentType);

            return contentType;
        }
    }
}
