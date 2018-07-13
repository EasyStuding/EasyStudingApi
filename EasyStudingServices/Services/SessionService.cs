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
using EasyStudingServices.Extensions;
using System.Linq;
using EasyStudingRepositories.DbContext;

namespace EasyStudingServices.Services
{
    public class SessionService : ISessionService
    {
        #region Initialize repositories.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<UserPassword> _userPasswordRepository;
        private readonly EasyStudingContext _context;

        public SessionService(IRepository<User> userRepository,
            IRepository<UserPassword> userPasswordRepository,
            EasyStudingContext context)
        {
            _userRepository = userRepository;
            _userPasswordRepository = userPasswordRepository;
            _context = context;
        }

        #endregion

        /// <summary>
        ///   Start registration by phone number.
        /// </summary>
        /// <param name="registrationModel">Model of registration user.</param>
        /// <returns>
        ///    Not validated user registration profile.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.InvalidOperationException">When the user is registered.</exception>

        public async Task<User> StartRegistration(RegistrationModel registrationModel)
        {
            registrationModel.CheckArgumentException();

            var containsUser = GetUserByTelephoneNumber(registrationModel.TelephoneNumber);

            if (containsUser == null)
            {
                return await _userRepository.AddAsync(new User
                {
                    TelephoneNumber = registrationModel.TelephoneNumber
                });
            }

            var passwordOfUser = GetUserPasswordByUserId(containsUser.Id) == null
                ? new UserPassword()
                : throw new InvalidOperationException();

            var userEntity = await _userRepository.EditAsync(new User()
            {
                Id = containsUser.Id,
                TelephoneNumber = containsUser.TelephoneNumber
            });

            SmsService.Send(userEntity.TelephoneNumber);

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
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>

        public async Task<User> ValidateRegistration(ValidateModel validateModel)
        {
            validateModel.CheckArgumentException();

            var user = await _userRepository
                .GetAsync(validateModel.UserId);

            user.TelephoneNumberIsValidated =
                validateModel
                .ValidationCode
                .ValidateCode(user.TelephoneNumber);

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Create InformationModel for user.
        /// </summary>
        /// <param name="loginModel">Login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>
        /// <exception cref="System.InvalidOperationException">When user registred.</exception>

        public async Task<LoginToken> CompleteRegistration(LoginModel loginModel)
        {
            loginModel.CheckArgumentException();

            var user = GetUserByTelephoneNumber(loginModel.TelephoneNumber)
                ?? throw new ArgumentNullException();

            var userPassword = GetUserPasswordByUserId(user.Id) == null
                ? new UserPassword()
                : throw new InvalidOperationException();

            userPassword = await _userPasswordRepository.AddAsync(new UserPassword()
            {
                UserId = user.Id,
                Password = loginModel.Password.HashPassword()
            });

            return GetToken(user);
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="loginModel">Login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>
        /// <exception cref="System.InvalidOperationException">When passwords not the same.</exception>

        public async Task<LoginToken> Login(LoginModel loginModel)
        {
            loginModel.CheckArgumentException();

            var user = _userRepository
                .GetAll()
                .Join(_context.UserPasswords,
                    u => u.Id,
                    up => up.UserId,
                    (u, up) => new
                    {
                        u.Id,
                        u.TelephoneNumber,
                        up.Password
                    })
                .FirstOrDefault(u => u.TelephoneNumber.Equals(loginModel.TelephoneNumber))
                ?? throw new ArgumentNullException();

            if (!user.Password.VerifyHashedPassword(loginModel.Password))
            {
                throw new InvalidOperationException();
            }

            return GetToken(await _userRepository.GetAsync(user.Id));
        }

        /// <summary>
        ///   Get validation code to phone number.
        /// </summary>
        /// <param name="registrationModel">Registration model.</param>
        /// <returns>
        ///    True or exception.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>

        public bool GetValidationCode(RegistrationModel registrationModel)
        {
            registrationModel.CheckArgumentException();

            SmsService.Send(registrationModel.TelephoneNumber);

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
        /// <exception cref="System.ArgumentNullException">When user not found or not registraited.</exception>
        /// <exception cref="System.InvalidOperationException">When validation code not the same.</exception>

        public async Task<LoginToken> RestorePassword(RestorePasswordModel restorePasswordModel)
        {
            restorePasswordModel.CheckArgumentException();

            if (!restorePasswordModel.ValidationCode.ValidateCode(restorePasswordModel.TelephoneNumber))
            {
                throw new InvalidOperationException();
            }

            var user = GetUserByTelephoneNumber(restorePasswordModel.TelephoneNumber)
                ?? throw new ArgumentNullException();

            var password = GetUserPasswordByUserId(user.Id)
                ?? throw new ArgumentNullException();

            password.Password = restorePasswordModel.Password.HashPassword();

            var editedPassword = await _userPasswordRepository.EditAsync(password);

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
            return GetToken(await _userRepository.GetAsync(currentUserId));
        }


        /// <summary>
        ///   For dev.
        ///   Delete in production.
        /// </summary>

        public async Task<bool> DeleteUserDev(string telNumber)
        {
            try
            {
                var user = GetUserByTelephoneNumber(telNumber)
                    ?? throw new ArgumentNullException();

                var password = GetUserPasswordByUserId(user.Id)
                    ?? throw new ArgumentNullException();

                var deletedPassword = await _userPasswordRepository.RemoveAsync(password.Id);

                var deletedUser = await _userRepository.RemoveAsync(user.Id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        #region Helpers.

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

        private User GetUserByTelephoneNumber(string telephoneNumber)
        {
            return _userRepository
                .GetAll()
                .FirstOrDefault(u =>
                    u.TelephoneNumber.Equals(telephoneNumber));
        }

        private UserPassword GetUserPasswordByUserId(long id)
        {
            return _userPasswordRepository
                .GetAll()
                .FirstOrDefault(up =>
                    up.UserId == id);
        }

        #endregion
    }
}
