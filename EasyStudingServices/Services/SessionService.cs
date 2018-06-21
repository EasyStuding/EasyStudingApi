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

namespace EasyStudingServices.Services
{
    public class SessionService : ISessionService
    {
        private readonly IRepository<Cost> CostRepository;
        private readonly IRepository<OpenSource> OpenSourceRepository;
        private readonly IRepository<Role> RoleRepository;
        private readonly IRepository<SubscriptionExecutor> SubscriptionExecutorRepository;
        private readonly IRepository<SubscriptionOpenSource> SubscriptionOpenSourceRepository;
        private readonly IRepository<UserInformation> UserInformationRepository;
        private readonly IRepository<UserRegistration> UserRegistrationRepository;
        private readonly IRepository<ValidationUser> ValidationUserRepository;

        public SessionService(
        IRepository<Cost> CostRepository,
        IRepository<OpenSource> OpenSourceRepository,
        IRepository<Role> RoleRepository,
        IRepository<SubscriptionExecutor> SubscriptionExecutorRepository,
        IRepository<SubscriptionOpenSource> SubscriptionOpenSourceRepository,
        IRepository<UserInformation> UserInformationRepository,
        IRepository<UserRegistration> UserRegistrationRepository,
        IRepository<ValidationUser> ValidationUserRepository)
        {
            this.CostRepository = CostRepository;
            this.OpenSourceRepository = OpenSourceRepository;
            this.RoleRepository = RoleRepository;
            this.SubscriptionExecutorRepository = SubscriptionExecutorRepository;
            this.SubscriptionOpenSourceRepository = SubscriptionOpenSourceRepository;
            this.UserInformationRepository = UserInformationRepository;
            this.UserRegistrationRepository = UserRegistrationRepository;
            this.ValidationUserRepository = ValidationUserRepository;
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
            var userReg = await UserRegistrationRepository.AddAsync(new UserRegistration
            {
                Id = 0,
                IsValidated = false,
                RegistrationDate = DateTime.Now,
                TelephoneNumber = apiUserRegistration.TelephoneNumber
            });

            var userValidation = await ValidationUserRepository.AddAsync(new ValidationUser()
            {
                Id = 0,
                UserRegistrationId = userReg.Id,
                ValidationCode = "111111"
            });

            return userReg;
        }

        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
        /// <param name="apiUserRegistration">Model of registration user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.InvalidOperationException">When validation code from model not equal validation code from db.</exception>

        public async Task<UserRegistration> ValidateRegistration(ValidationUser validationUser)
        {
            var validationEntity = ValidationUserRepository.GetAll().FirstOrDefault(vr => vr.UserRegistrationId == validationUser.UserRegistrationId);

            if (!validationUser.ValidationCode.Equals(validationEntity.ValidationCode))
            {
                throw new InvalidOperationException();
            }

            var userReg = await UserRegistrationRepository.GetAsync(validationUser.UserRegistrationId);

            userReg.IsValidated = true;

            userReg = await UserRegistrationRepository.EditAsync(userReg);

            var removeValidationEntityResult = await ValidationUserRepository.RemoveAsync(validationEntity.Id);

            return userReg;
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
        /// <exception cref="System.InvalidOperationException">When user with this login contains in db.</exception>

        public async Task<ApiLoginToken> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin)
        {
            var costs = CostRepository.GetAll().ToList();

            var openSourceCost = costs.LastOrDefault(c => c.Product.ToLower().Contains("open source subscription"));

            var executorCost = costs.LastOrDefault(c => c.Product.ToLower().Contains("executor subscription"));

            var openSourceSubscription = await SubscriptionOpenSourceRepository.AddAsync(new SubscriptionOpenSource()
            {
                Id = 0,
                CostId = openSourceCost.Id,
                IsActive = true,
                DateExpires = DateTime.Now.AddMonths(3)
            });

            var openSource = await OpenSourceRepository.AddAsync(new OpenSource()
            {
                Id = 0,
                OpenSourceSubscriptionId = openSourceSubscription.Id
            });

            var executorSubscription = await SubscriptionExecutorRepository.AddAsync(new SubscriptionExecutor()
            {
                Id = 0,
                CostId = executorCost.Id,
                IsActive = true,
                DateExpires = DateTime.Now.AddMonths(3)
            });

            var userInfo = await UserInformationRepository.AddAsync(new UserInformation()
            {
                Id = 0,
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

            var apiUserInfoModel = new ApiUserInformationModel()
            {
                Id = userInfo.Id,
                LoginName = userInfo.LoginName,
                Role = (await RoleRepository.GetAsync(userInfo.RoleId)).Name
            };

            return new ApiLoginToken()
            {
                Id = apiUserInfoModel.Id,
                Login = apiUserInfoModel.LoginName,
                Role = apiUserInfoModel.Role,
                Token = GetToken(apiUserInfoModel)
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
            var userInfo = UserInformationRepository.GetAll().FirstOrDefault(u => 
                u.LoginName.ToLower().Equals(apiLogin.Login.ToLower()) && u.Password.Equals(apiLogin.Password));

            if (userInfo == null)
            {
                throw new ArgumentNullException();
            }

            var apiUserInfoModel = new ApiUserInformationModel()
            {
                Id = userInfo.Id,
                LoginName = userInfo.LoginName,
                Role = (await RoleRepository.GetAsync(userInfo.RoleId)).Name
            };

            return new ApiLoginToken()
            {
                Id = apiUserInfoModel.Id,
                Login = apiUserInfoModel.LoginName,
                Role = apiUserInfoModel.Role,
                Token = GetToken(apiUserInfoModel)
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
            var userInfo = await UserInformationRepository.GetAsync(currentUserId);

            if (userInfo == null)
            {
                throw new ArgumentNullException();
            }

            var apiUserInfoModel = new ApiUserInformationModel()
            {
                Id = userInfo.Id,
                LoginName = userInfo.LoginName,
                Role = (await RoleRepository.GetAsync(userInfo.RoleId)).Name
            };

            return new ApiLoginToken()
            {
                Id = apiUserInfoModel.Id,
                Login = apiUserInfoModel.LoginName,
                Role = apiUserInfoModel.Role,
                Token = GetToken(apiUserInfoModel)
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
