using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EasyStudingRepositories.Extensions
{
    public static class ValidatorExtension
    {
        public const int VALID_MINUTES = 5;

        public static string GetValidationCode(this string key, int minutes = VALID_MINUTES)
        {
            key = key + DateTime.Now.AddMinutes(minutes).ToString("dd/MM/yy HH:mm");

            var strToRet = "";

            using (MD5 md5Hash = MD5.Create())
            {
                var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(key));

                var strArr = data.Select(b => b.ToString("x2")).Skip(10).Take(3);

                foreach (var ch in strArr)
                {
                    strToRet += ch;
                }
            }

            return strToRet.ToUpper();
        }

        public static bool ValidateCode(this string code, string key)
        {
            for (var i = 0; i <= VALID_MINUTES; i++)
            {
                if (code.ToUpper().Equals(GetValidationCode(key, i)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
