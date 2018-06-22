using EasyStudingInterfaces.Repositories;
using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;

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


    }
}
