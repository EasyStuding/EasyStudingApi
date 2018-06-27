using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<User> StartRegistration(RegistrationModel registrationModel)
        {
            var containsUser = _userRepository
                .GetAll()
                .FirstOrDefault(u =>
                    u.TelephoneNumber.Equals(registrationModel.TelephoneNumber));

            if (containsUser == null)
            {
                return await _userRepository.AddAsync(new User
                {
                    TelephoneNumber = registrationModel.TelephoneNumber
                });
            }

            var passwordOfUser = _userPasswordRepository
                .GetAll()
                .FirstOrDefault(up => up.UserId == containsUser.Id)
                ?? throw new InvalidOperationException();

            return await _userRepository.EditAsync(new User()
            {
                Id = containsUser.Id,
                TelephoneNumber = containsUser.TelephoneNumber
            });
        }

        public async Task<User> ValidateRegistration(ValidateModel validateModel)
        {
            var user = await _userRepository
                .GetAsync(validateModel.UserId)
                ?? throw new ArgumentNullException();

            user.TelephoneNumberIsValidated = 
                ConfirmValidationCode(user, validateModel.ValidationCode);

            return await _userRepository.EditAsync(user);
        }

        public async Task<User> CompleteRegistration(LoginModel loginModel)
        {
            var user = _userRepository
                .GetAll()
                .FirstOrDefault(u => 
                    u.TelephoneNumber.Equals(loginModel.TelephoneNumber))
                ?? throw new ArgumentNullException();

            var userPassword = _userPasswordRepository
                .GetAll()
                .FirstOrDefault(up => up.UserId == user.Id) == null
                ? new UserPassword()
                : throw new InvalidOperationException();

            userPassword = await _userPasswordRepository.AddAsync(new UserPassword()
            {
                UserId = user.Id,
                Password = loginModel.Password
            }) ?? throw new InvalidOperationException();

            return user;
        }

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

        public async Task<User> GetUserById(long currentUserId)
        {
            return await _userRepository
                .GetAsync(currentUserId)
                ?? throw new ArgumentNullException();
        }

        // Edit in production.
        private bool ConfirmValidationCode(User user, string code)
        {
            var currentValidationCode = "111111";

            return currentValidationCode.Equals(code);
        }
    }
}
