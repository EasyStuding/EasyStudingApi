using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace EasyStudingServices.Extensions
{
    public static class UserExtension
    {
        public static void CheckExecutorSubscription(this User user)
        {
            if (user.SubscriptionExecutorExpiresDate == null
                || user.SubscriptionExecutorExpiresDate <= DateTime.Now)
            {
                throw new UnauthorizedAccessException();
            }
        }
        
        //Create hash of password.
        public static string HashPassword(this string password)
        {
            byte[] salt;
            byte[] buffer2;

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }

            byte[] dst = new byte[0x31];

            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);

            return Convert.ToBase64String(dst);
        }

        //Verify password.
        public static bool VerifyHashedPassword(this string hashedPassword, string password)
        {
            byte[] buffer4;

            byte[] src = Convert.FromBase64String(hashedPassword);

            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }

            byte[] dst = new byte[0x10];

            Buffer.BlockCopy(src, 1, dst, 0, 0x10);

            byte[] buffer3 = new byte[0x20];

            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }

            return buffer3.SequenceEqual(buffer4);
        }
    }
}
