using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using EasyStudingModels;
using Microsoft.IdentityModel.Tokens;
using EasyStudingRepositories.Repositories;

namespace EasyStudingServices.Services
{
    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _sessionRepository;

        public SessionService(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        /// <summary>
        ///   Start registration by phone number.
        /// </summary>
        /// <param name="apiUserRegistration">Model of registration user.</param>
        /// <returns>
        ///    Not validated user registration profile.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            if (!apiUserRegistration.Validate())
            {
                throw new FormatException();
            }

            return await _sessionRepository.StartRegistration(apiUserRegistration);
        }

        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
		/// <param name="validationUser">Model of validation user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<UserRegistration> ValidateRegistration(ValidationUser validationUser)
        {
            if (!validationUser.Validate())
            {
                throw new FormatException();
            }

            var userEntity = await _sessionRepository.ValidateRegistration(validationUser);

            if(userEntity == null)
            {
                throw new ArgumentNullException();
            }

            return userEntity;
        }

        /// <summary>
        ///   Create InformationModel for user.
        /// </summary>
        /// <param name="apiRegistrationLogin">Registration of login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiLoginToken> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin)
        {
            if (!apiRegistrationLogin.Validate())
            {
                throw new FormatException();
            }

            var userEntity = await _sessionRepository.CompleteRegistration(apiRegistrationLogin);

            if (userEntity == null)
            {
                throw new ArgumentNullException();
            }

            return new ApiLoginToken()
            {
                Id = userEntity.Id,
                Login = userEntity.LoginName,
                Role = userEntity.Role,
                Token = GetToken(userEntity)
            };
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="apiLogin">Login model.</param>
        /// <param name="isTelephone">Check condition(telephone/login).</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiLoginToken> Login(ApiLoginModel apiLogin, bool isTelephone)
        {
            if (!apiLogin.Validate())
            {
                throw new FormatException();
            }

            var userEntity = await _sessionRepository.GetApiUserInformationFromApiLoginAsync(apiLogin);

            if (userEntity == null)
            {
                throw new ArgumentNullException();
            }

            return new ApiLoginToken()
            {
                Id = userEntity.Id,
                Login = userEntity.LoginName,
                Role = userEntity.Role,
                Token = GetToken(userEntity)
            };
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiLoginToken> UpdateToken(long currentUserId)
        {
            var userEntity = await _sessionRepository.GetApiUserInformationByIdAsync(currentUserId);

            if (userEntity == null)
            {
                throw new ArgumentNullException();
            }

            return new ApiLoginToken()
            {
                Id = userEntity.Id,
                Login = userEntity.LoginName,
                Role = userEntity.Role,
                Token = GetToken(userEntity)
            };
        }

        private string GetToken(ApiUserInformationModel param)
        {
            if (param != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("Id", param.Id.ToString()),
                    new Claim(ClaimsIdentity.DefaultNameClaimType, param.LoginName),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, param.Role)
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);

                var now = DateTime.UtcNow;
                var jwt = new JwtSecurityToken(
                        notBefore: now,
                        claims: claimsIdentity.Claims,
                        expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFE_TIME)),
                        signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
                        );
                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

                return encodedJwt;
            }

            throw new ArgumentNullException();
        }
    }
}
