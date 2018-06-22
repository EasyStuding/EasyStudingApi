using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class SessionRepository
    {
        private readonly IRepository<Cost> _costRepository;
        private readonly IRepository<OpenSource> _openSourceRepository;
        private readonly IRepository<Role> _roleRepository;
        private readonly IRepository<SubscriptionExecutor> _subscriptionExecutorRepository;
        private readonly IRepository<SubscriptionOpenSource> _subscriptionOpenSourceRepository;
        private readonly IRepository<UserInformation> _userInformationRepository;
        private readonly IRepository<UserRegistration> _userRegistrationRepository;
        private readonly IRepository<ValidationUser> _validationUserRepository;

        private readonly EasyStudingContext _context;

        private readonly IMapper _mapper;

        public SessionRepository(EasyStudingContext context)
        {
            _context = context;
            _costRepository = new UniversalRepository<Cost>(_context);
            _openSourceRepository = new UniversalRepository<OpenSource>(_context);
            _subscriptionExecutorRepository = new UniversalRepository<SubscriptionExecutor>(_context);
            _subscriptionOpenSourceRepository = new UniversalRepository<SubscriptionOpenSource>(_context);
            _userInformationRepository = new UniversalRepository<UserInformation>(_context);
            _userRegistrationRepository = new UniversalRepository<UserRegistration>(_context);
            _validationUserRepository = new UniversalRepository<ValidationUser>(_context);
        }

        public async Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            var userReg = await _userRegistrationRepository.AddAsync(new UserRegistration
            {
                Id = 0,
                IsValidated = false,
                RegistrationDate = DateTime.Now,
                TelephoneNumber = apiUserRegistration.TelephoneNumber
            });

            var userValidation = await _validationUserRepository.AddAsync(new ValidationUser()
            {
                Id = 0,
                UserRegistrationId = userReg.Id,
                ValidationCode = "111111"
            });

            return userReg;
        }

        public async Task<UserRegistration> ValidateRegistration(ValidationUser validationUser)
        {
            var validationEntity = _validationUserRepository.GetAll().FirstOrDefault(vr => vr.UserRegistrationId == validationUser.UserRegistrationId);

            if (!validationUser.ValidationCode.Equals(validationEntity.ValidationCode))
            {
                throw new InvalidOperationException();
            }

            var userReg = await _userRegistrationRepository.GetAsync(validationUser.UserRegistrationId);

            userReg.IsValidated = true;

            await _userRegistrationRepository.EditAsync(userReg);

            await _validationUserRepository.RemoveAsync(validationEntity.Id);

            return userReg;
        }

        public async Task<ApiUserInformationModel> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin)
        {
            var costs = _costRepository.GetAll().ToList();

            var openSourceCost = GetSubstractionCost(costs,Defines.Subscription.OPEN_SOURSE);

            var executorCost = GetSubstractionCost(costs,Defines.Subscription.EXECUTOR);

            var openSourceSubscription = await _subscriptionOpenSourceRepository.AddAsync(new SubscriptionOpenSource()
            {
                CostId = openSourceCost.Id,
                IsActive = true,
                DateExpires = DateTime.Now.AddMonths(Defines.Subscription.COUNT_MONTH)
            });

            var openSource = await _openSourceRepository.AddAsync(new OpenSource()
            {
                OpenSourceSubscriptionId = openSourceSubscription.Id
            });

            var executorSubscription = await _subscriptionExecutorRepository.AddAsync(new SubscriptionExecutor()
            {
                CostId = executorCost.Id,
                IsActive = true,
                DateExpires = DateTime.Now.AddMonths(Defines.Subscription.COUNT_MONTH)
            });

            var userInfo = await _userInformationRepository.AddAsync(new UserInformation()
            {
                IsBanned = false,
                IsFreeTrial = true,
                IsGaranted = false,
                LoginName = apiRegistrationLogin.Login,
                Password = apiRegistrationLogin.Password,
                UserRegistrationId = apiRegistrationLogin.UserRegistrationId,
                RoleId = 1,
                OpenSourceId = openSource.Id,
                SubscriptionExecutorId = executorSubscription.Id
            });

            return new ApiUserInformationModel()
            {
                Id = userInfo.Id,
                LoginName = userInfo.LoginName,
                Role = (await _roleRepository.GetAsync(userInfo.RoleId)).Name
            };

        }

        private Cost GetSubstractionCost(IEnumerable<Cost> costs, string substraction)
        {
           return costs.LastOrDefault(c => c.Product.ToLower().Contains(substraction));
        }
    }
}
