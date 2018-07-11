using System;
using System.Text;
using System.Collections.Generic;

namespace EasyStudingModels
{
    public static class Defines
    {
        public static class Subscription
        {
            public const string OPEN_SOURSE = "open source subscription";

            public const string EXECUTOR = "executor subscription";

            public const int COUNT_MONTH = 3;
        }

        public static class Roles
        {
            public const string USER = "user";

            public const string MODERATOR = "moderator";

            public const string ADMIN = "admin";
        }

        public static class AttachmentContainerName
        {
            public const string USER = "user";

            public const string ORDER = "order";
        }

        public static class FileFolders
        {
            public static readonly Dictionary<string, string> FolderPathes =
                new Dictionary<string, string>()
                {
                            {
                                USER_PICTURES_FOLDER, "wwwroot/uploads/userpictures"
                            },
                            {
                                ORDER_ATTACHMENTS_FOLDER, "wwwroot/uploads/orderattachments"
                            },
                            {
                                OPENSOURCE_ATTACHMENT_FOLDER, "wwwroot/uploads/opensourceattachments"
                            },
                            {
                                LOGS_FOLDER, "wwwroot/logs"
                            }
                };

            public const string USER_PICTURES_FOLDER = "userpictures";

            public const string ORDER_ATTACHMENTS_FOLDER = "orderattachments";

            public const string OPENSOURCE_ATTACHMENT_FOLDER = "opensourceattachments";

            public const string LOGS_FOLDER = "logs";
        }

        public static class DBCreds
        {
            public static readonly string HOST =
                GetDecodedString("ZHVtYm8uZGIuZWxlcGhhbnRzcWwuY29t");

            public static readonly string PORT = 
                GetDecodedString("NTQzMg==");

            public static readonly string DATABASE = 
                GetDecodedString("a3dmZWhucG4=");

            public static readonly string USERNAME = 
                GetDecodedString("a3dmZWhucG4=");

            public static readonly string PASSWORD = 
                GetDecodedString("OFJDX0NCR29faFRmckMwWERQT2xKQnFDbVFQYk00b2k=");
        }

        #region Get decoded string from base64 format.
        public static string GetDecodedString(string str)
        {
            return Encoding
                .UTF8
                .GetString(Convert.FromBase64String(str));
        }
        #endregion
    }
}
