using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingModels.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using EasyStudingModels;
using Microsoft.IdentityModel.Tokens;

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
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<User> StartRegistration(RegistrationModel registrationModel)
        {
            registrationModel.CheckArgumentException();

            var userEntity = await _sessionRepository.StartRegistration(registrationModel);

            var result = SmsService.Send(userEntity.TelephoneNumber, _sessionRepository.GetValidationCode(userEntity.TelephoneNumber + DateTime.Now.AddMinutes(3).Minute));

            return userEntity;
        }

        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
		/// <param name="validationUser">Model of validation user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<User> ValidateRegistration(ValidateModel validateModel)
        {
            validateModel.CheckArgumentException();

            var userEntity = await _sessionRepository.ValidateRegistration(validateModel)
                ?? throw new ArgumentNullException();

            return userEntity;
        }

        /// <summary>
        ///   Create InformationModel for user.
        /// </summary>
        /// <param name="apiRegistrationLogin">Registration of login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<LoginToken> CompleteRegistration(LoginModel loginModel)
        {
            loginModel.CheckArgumentException();

            var userEntity = await _sessionRepository.CompleteRegistration(loginModel) 
                ?? throw new ArgumentNullException();

            return GetToken(userEntity);
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="apiLogin">Login model.</param>
        /// <param name="isTelephone">Check condition(telephone/login).</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<LoginToken> Login(LoginModel loginModel)
        {
            loginModel.CheckArgumentException();

            var userEntity = await _sessionRepository.Login(loginModel)
                ?? throw new ArgumentNullException();

            return GetToken(userEntity);
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<LoginToken> UpdateToken(long currentUserId)
        {
            var userEntity = await _sessionRepository.GetUserById(currentUserId)
                ?? throw new ArgumentNullException();

            return GetToken(userEntity);
        }

        #region Generate jwt token.

        private LoginToken GetToken(User user)
        {            
            var claims = new List<Claim>
                {
                    new Claim("Id", user.Id.ToString()),
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.TelephoneNumber),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
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

            return new LoginToken()
            {
                Id = user.Id,
                TelephoneNumber = user.TelephoneNumber,
                Role = user.Role,
                BearerToken = "Bearer " + encodedJwt
            }; 
        }

        #endregion
    }
}
