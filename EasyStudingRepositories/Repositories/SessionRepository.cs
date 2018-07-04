using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class SessionRepository: ISessionRepository
    {
        #region Repositories from db.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<UserPassword> _userPasswordRepository;

        #endregion

        private readonly EasyStudingContext _context;

        public SessionRepository(EasyStudingContext context)
        {
            _context = context;
            _userRepository = new UniversalRepository<User>(_context);
            _userPasswordRepository = new UniversalRepository<UserPassword>(_context);
        }

        /// <summary>
        ///   Start registration by phone number.
        /// </summary>
        /// <param name="registrationModel">Model of registration user.</param>
        /// <returns>
        ///    Not validated user registration profile.
        /// </returns>
        /// <exception cref="System.InvalidOperationException">When the user is registered.</exception>

        public async Task<User> StartRegistration(RegistrationModel registrationModel)
        {
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

            return await _userRepository.EditAsync(new User()
            {
                Id = containsUser.Id,
                TelephoneNumber = containsUser.TelephoneNumber
            });
        }

        /// <summary>
        ///   Validate registration by user id and validation code.
        /// </summary>
        /// <param name="validateModel">Model of validation user.</param>
        /// <returns>
        ///    Validated user profile.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>

        public async Task<User> ValidateRegistration(ValidateModel validateModel)
        {
            var user = await GetUserById(validateModel.UserId)
                ?? throw new ArgumentNullException();

            user.TelephoneNumberIsValidated = 
                ValidateCode(validateModel.ValidationCode, user.TelephoneNumber);

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Complete registration by user telephone and password.
        /// </summary>
        /// <param name="loginModel">Model of login user.</param>
        /// <returns>
        ///     Registraited user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>
        /// <exception cref="System.InvalidOperationException">When user registred.</exception>

        public async Task<User> CompleteRegistration(LoginModel loginModel)
        {
            var user = GetUserByTelephoneNumber(loginModel.TelephoneNumber)
                ?? throw new ArgumentNullException();

            var userPassword = GetUserPasswordByUserId(user.Id) == null
                ? new UserPassword()
                : throw new InvalidOperationException();

            userPassword = await _userPasswordRepository.AddAsync(new UserPassword()
            {
                UserId = user.Id,
                Password = loginModel.Password
            }) ?? throw new InvalidOperationException();

            return user;
        }

        /// <summary>
        ///   Login by user telephone and password.
        /// </summary>
        /// <param name="loginModel">Model of login user.</param>
        /// <returns>
        ///     Registraited user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>
        /// <exception cref="System.InvalidOperationException">When passwords not the same.</exception>

        public async Task<User> Login(LoginModel loginModel)
        {
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

            if (!user.Password.Equals(loginModel.Password))
            {
                throw new InvalidOperationException();
            }

            return await GetUserById(user.Id);
        }

        /// <summary>
        ///   Get user by ID.
        /// </summary>
        /// <param name="currentUserId">Id of user to return.</param>
        /// <returns>
        ///     User.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When user not found.</exception>

        public async Task<User> GetUserById(long currentUserId)
        {
            return await _userRepository
                .GetAsync(currentUserId);
        }

        /// <summary>
        ///   Get validation code by key.
        /// </summary>
        /// <param name="key">Key to generate validation code.</param>
        /// <returns>
        ///     Validation code.
        /// </returns>

        public string GetValidationCode(string key)
        {
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

        /// <summary>
        ///   Restore password by telephone number and validation code.
        /// </summary>
        /// <param name="restorePasswordModel">Model to restore password.</param>
        /// <returns>
        ///     User.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When user not found or not registraited.</exception>
        /// <exception cref="System.InvalidOperationException">When validation code not the same.</exception>

        public async Task<User> RestorePassword(RestorePasswordModel restorePasswordModel)
        {
            if (!ValidateCode(restorePasswordModel.ValidationCode, restorePasswordModel.TelephoneNumber))
            {
                throw new InvalidOperationException();
            }

            var user = GetUserByTelephoneNumber(restorePasswordModel.TelephoneNumber)
                ?? throw new ArgumentNullException();

            var password = GetUserPasswordByUserId(user.Id)
                ?? throw new ArgumentNullException();

            password.Password = restorePasswordModel.Password;

            var editedPassword = await _userPasswordRepository.EditAsync(password);

            return user;
        }

        // For dev.
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

        private bool ValidateCode(string code, string telephone)
        {
            for (var i = 0; i <= 3; i++)
            {
                if (code.ToUpper().Equals(GetValidationCode(telephone 
                    + DateTime.Now.AddMinutes(i).ToString("dd/MM/yy HH:mm"))))
                {
                    return true;
                }
            }
            return false;
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
    }
}
