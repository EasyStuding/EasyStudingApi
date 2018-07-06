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

        public static class Mega
        {
            public static Dictionary<string, string> CREDS = 
                new Dictionary<string, string>() { { "s.a.mokin@list.ru", "DefaultAdmin123!" } };
        }
    }
}
