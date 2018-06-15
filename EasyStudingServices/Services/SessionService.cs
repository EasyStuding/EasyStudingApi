using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    public class SessionService: ISessionService
    {
        //TODO: initialize repositories;

        /// <summary>
        ///   Start registration by phone number.
        /// </summary>
        /// <param name="apiUserRegistration">Model of registration user.</param>
        /// <returns>
        ///    Not validated user registration profile.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            throw new Exception();
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
            throw new Exception();
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
            throw new Exception();
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
            throw new Exception();
        }
    }
}
