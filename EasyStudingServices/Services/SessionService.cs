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
        /// <param name="registrationModel">Model of registration user.</param>
        /// <returns>
        ///    Not validated user registration profile.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<User> StartRegistration(RegistrationModel registrationModel)
        {
            registrationModel.CheckArgumentException();

            var userEntity = await _sessionRepository.StartRegistration(registrationModel);

            SmsService.Send(userEntity.TelephoneNumber, _sessionRepository.GetValidationCode(userEntity.TelephoneNumber 
                + DateTime.Now.AddMinutes(3).ToString("dd/MM/yy HH:mm")));

            return userEntity;
        }

        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
		/// <param name="validateModel">Model of validation user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

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
        /// <param name="loginModel">Login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

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
        /// <param name="loginModel">Login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<LoginToken> Login(LoginModel loginModel)
        {
            loginModel.CheckArgumentException();

            var userEntity = await _sessionRepository.Login(loginModel)
                ?? throw new ArgumentNullException();

            return GetToken(userEntity);
        }

        /// <summary>
        ///   Get validation code to phone number.
        /// </summary>
        /// <param name="registrationModel">Registration model.</param>
        /// <returns>
        ///    True or exception.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public bool GetValidationCode(RegistrationModel registrationModel)
        {
            registrationModel.CheckArgumentException();

            SmsService.Send(registrationModel.TelephoneNumber, _sessionRepository.GetValidationCode(registrationModel.TelephoneNumber
                + DateTime.Now.AddMinutes(3).ToString("dd/MM/yy HH:mm")));

            return true;
        }

        /// <summary>
        ///   Restore password by telephone number.
        /// </summary>
        /// <param name="restorePasswordModel">Restore password model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<LoginToken> RestorePassword(RestorePasswordModel restorePasswordModel)
        {
            restorePasswordModel.CheckArgumentException();

            var user = await _sessionRepository.RestorePassword(restorePasswordModel);

            return GetToken(user);
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>

        public async Task<LoginToken> UpdateToken(long currentUserId)
        {
            var userEntity = await _sessionRepository.GetUserById(currentUserId)
                ?? throw new ArgumentNullException();

            return GetToken(userEntity);
        }


        /// <summary>
        ///   For dev.
        ///   Delete in production.
        /// </summary>
        public async Task<bool> DeleteUserDev(string telNumber)
        {
            return await _sessionRepository.DeleteUserDev(telNumber);
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
                User = user,
                BearerToken = "Bearer " + encodedJwt
            }; 
        }

        #endregion
    }
}
