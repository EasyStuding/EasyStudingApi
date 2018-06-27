﻿using EasyStudingModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface ISessionRepository
    {
        Task<User> StartRegistration(RegistrationModel registrationModel);

        Task<User> ValidateRegistration(ValidateModel validateModel);

        Task<User> CompleteRegistration(LoginModel loginModel);

        Task<User> GetUserById(long currentUserId);

        Task<User> GetUserByLoginModel(LoginModel loginModel);
    }
}