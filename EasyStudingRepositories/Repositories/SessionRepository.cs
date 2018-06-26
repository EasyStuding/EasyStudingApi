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
        #region Repositories from db

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
            var containsUser = _userRepository.GetAll().FirstOrDefault(u => u.TelephoneNumber.Equals(registrationModel.TelephoneNumber));

            if (containsUser != null
                && containsUser.TelephoneNumberIsValidated == true)
            {
                throw new InvalidOperationException();
            }
            else if (containsUser != null
                && containsUser.TelephoneNumberIsValidated == false)
            {
                return await _userRepository.EditAsync(new User()
                {
                    Id = containsUser.Id,
                    TelephoneNumber = containsUser.TelephoneNumber
                });
            }

            var userReg = await _userRepository.AddAsync(new User
            {
                TelephoneNumber = registrationModel.TelephoneNumber
            });

            return userReg;
        }

        public async Task<User> ValidateRegistration(ValidateModel validateModel)
        {
            var validationEntity = await _userRepository.GetAsync(validateModel.UserId);

            if (validationEntity == null)
            {
                throw new ArgumentNullException();
            }

            if (!"111111".Equals(validateModel.ValidationCode))
            {
                throw new InvalidOperationException();
            }

            validationEntity.TelephoneNumberIsValidated = true;

            await _userRepository.EditAsync(validationEntity);

            return validationEntity;
        }

        public async Task<User> CompleteRegistration(LoginModel loginModel)
        {
            var user = _userRepository.GetAll().FirstOrDefault(u => u.TelephoneNumber.Equals(loginModel.TelephoneNumber));

            if (user == null)
            {
                throw new ArgumentNullException();
            }

            var userPassword = await _userPasswordRepository.AddAsync(new UserPassword()
            {
                UserId = user.Id,
                Password = loginModel.Password
            });

            if (userPassword == null)
            {
                throw new InvalidOperationException();
            }

            return user;
        }

        public async Task<User> GetUserById(long currentUserId)
        {
            var userInfo = await _userRepository.GetAsync(currentUserId);

            if (userInfo == null)
            {
                throw new ArgumentNullException();
            }

            return userInfo;
        }

        public async Task<User> GetUserByLoginModel(LoginModel loginModel)
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
                .FirstOrDefault(u => u.TelephoneNumber.Equals(loginModel.TelephoneNumber));

            if (user == null)
            {
                throw new ArgumentNullException();
            }

            if (!user.Password.Equals(loginModel.Password))
            {
                throw new InvalidOperationException();
            }

            return await _userRepository.GetAsync(user.Id);
        }
    }
}
