using System;
using System.Text.RegularExpressions;

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

        public static bool IsValidContainerName(this string containerName)
        {
            return !string.IsNullOrWhiteSpace(containerName)
                && (containerName.Equals(Defines.AttachmentContainerName.USER)
                || containerName.Equals(Defines.AttachmentContainerName.ORDER));
        }

        public static bool IsValidSubscription(this string sub)
        {
            return !string.IsNullOrWhiteSpace(sub)
                && (sub.Equals(Defines.Subscription.EXECUTOR) 
                || sub.Equals(Defines.Subscription.OPEN_SOURSE));
        }

        public static bool IsValidEmail(this string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidTelephoneNumber(this string telNumber)
        {
            //Need to contain 9-16 digits and start with +.
            const string PATTERN = @"\+\d{9,16}$";

            return string.IsNullOrWhiteSpace(telNumber)
                ? false
                : new Regex(PATTERN).Match(telNumber).Success;
        }

        public static bool IsValidPassword(this string passowrd)
        {
            //Must contain uppercase / lowercase letter, digit, longer than 8 characters.
            const string PATTERN = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";

            return string.IsNullOrWhiteSpace(passowrd)
                ? false
                : new Regex(PATTERN).Match(passowrd).Success;
        }
    }
}
