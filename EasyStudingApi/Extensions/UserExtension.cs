using System.Linq;
using System.Security.Claims;

namespace EasyStudingApi.Extensions
{
    public static class UserExtension
    {
        public static long GetUserId(this ClaimsPrincipal user)
        {
            return long.Parse(user.Claims.FirstOrDefault().Value);
        }
    }
}
