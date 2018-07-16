using EasyStudingModels;
using EasyStudingModels.Extensions;
using EasyStudingModels.Models;
using System;
using System.IO;

namespace EasyStudingRepositories.DbContext
{
    public static class FileStorage
    {
        public static FileToReturnModel UploadFile(FileToAddModel file, string currentUrl, string folder)
        {
            file.Name = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds + file.Name;

            var path = Path.Combine(Directory.GetCurrentDirectory(),
                Defines.FileFolders.FolderPathes[folder],
                file.Name);

            var data = Convert.FromBase64String(file.Data);

            File.WriteAllBytes(path, data);

            return new FileToReturnModel()
            {
                ContainerId = file.ContainerId,
                ContainerName = file.ContainerName,
                Link = new Uri(currentUrl + "/"
                    + Defines.FileFolders.FolderPathes[folder].Replace("wwwroot", "") + "/"
                    + file.Name).AbsoluteUri,
                Name = file.Name,
                Type = file.Name.GetContentType()
            };
        }

        public static Stream GetFileStream(string fileLink, string folder)
        {
            return File.OpenRead(Path.Combine(Directory.GetCurrentDirectory(),
                Defines.FileFolders.FolderPathes[folder],
                Path.GetFileName(fileLink)));
        }
    }
}
