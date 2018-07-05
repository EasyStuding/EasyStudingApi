using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace EasyStudingModels
{
    public class AuthOptions
    {
        private const string _key = "lkjohn98324mcvbu/';ly!af./23468241bsdf!@enfqife2053631.,,dfas;d@!"; //Encryption key.

        public const int LIFE_TIME = 40320; //The lifetime of the token is 4 weeks (in minutes).

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_key));
        }
    }
}
