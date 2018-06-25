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
    public class UserRepository : IUserRepository
    {
        private readonly EasyStudingContext _context;

        public UserRepository(EasyStudingContext context)
        {
            _context = context;
        }
    }
}
