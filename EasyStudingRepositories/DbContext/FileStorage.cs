using CG.Web.MegaApiClient;
using EasyStudingModels;
using EasyStudingModels.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EasyStudingRepositories.DbContext
{
    public static class FileStorage
    {
        private static readonly KeyValuePair<string, string> _creds = Defines.Mega.CREDS.Last();

        private static readonly MegaApiClient _client = new MegaApiClient();

        public static FileToReturnModel UploadFile(FileToAddModel file)
        {
            try
            {
                _client.Login(_creds.Key, _creds.Value);

                var root = _client
                    .GetNodes()
                    .Single(x => x.Type == NodeType.Root);

                using (var stream = new MemoryStream(Convert.FromBase64String(file.Data)))
                {
                    var uploadedFile = _client.Upload(stream, file.Name, root);

                    return new FileToReturnModel()
                    {
                        Name = uploadedFile.Name,
                        Type = file.Type,
                        DownloadLink = _client.GetDownloadLink(uploadedFile).ToString()
                    };
                }
            }
            finally
            {
                _client.Logout();
            }
        }
    }
}
