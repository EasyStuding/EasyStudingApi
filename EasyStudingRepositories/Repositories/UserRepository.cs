using EasyStudingInterfaces.Repositories;
using EasyStudingModels;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using EasyStudingRepositories.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace EasyStudingRepositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Repositories from db.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<UserPassword> _userPasswordRepository;
        private readonly IRepository<Attachment> _attachmentRepository;

        #endregion

        private readonly EasyStudingContext _context;

        public UserRepository(EasyStudingContext context)
        {
            _context = context;
            _userRepository = new UniversalRepository<User>(_context);
            _orderRepository = new UniversalRepository<Order>(_context);
            _userPasswordRepository = new UniversalRepository<UserPassword>(_context);
            _attachmentRepository = new UniversalRepository<Attachment>(_context);
        }

        /// <summary>
        ///   Get users, classified by education and city. 
        /// </summary>
        /// <param name="education">Education of user.</param>
        /// <param name="country">Country of user.</param>
        /// <param name="city">City of user.</param>
        /// <returns>
        ///    Users sorted by city and education.
        /// </returns>

        public IQueryable<User> GetUsers(string education, string country, string region, string city)
        {
            return _userRepository.GetAll().Where(u =>
               u.Education.Contains(education)
               && u.Country.Contains(country)
               && u.Region.Contains(region)
               && u.City.Contains(city));
        }

        /// <summary>
        ///   Get information about user. 
        /// </summary>
        /// <param name="id">Id of user to return.</param>
        /// <returns>
        ///    Requsted user.
        /// </returns>

        public async Task<User> GetUser(long id)
        {
            return await _userRepository.GetAsync(id);
        }

        /// <summary>
        ///   Get orders of current user. 
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Orders.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user not found.</exception>

        public async Task<IQueryable<Order>> GetOrders(long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId)
                ?? throw new UnauthorizedAccessException();

            return _orderRepository.GetAll().Where(o => o.CustomerId == user.Id
            || o.ExecutorId == user.Id);
        }

        /// <summary>
        ///   Get order of current user by id. 
        /// </summary>
        /// <param name="id">Id of current user order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user not found or Customer/Executor of order != current user.</exception>

        public async Task<Order> GetOrder(long id, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId)
                ?? throw new UnauthorizedAccessException();

            return _orderRepository.GetAll().FirstOrDefault(o => o.Id == id
                && (o.CustomerId == user.Id || o.ExecutorId == user.Id));
        }

        /// <summary>
        ///   Get executors. 
        /// </summary>
        /// <param name="education">Education of executore.</param>
        /// <param name="country">Country of executore.</param>
        /// <param name="city">City of executor.</param>
        /// <returns>
        ///    Executors.
        /// </returns>

        public IQueryable<User> GetExecutors(string education, string country, string region, string city)
        {
            return _userRepository.GetAll().Where(u =>
               u.Education.Contains(education)
               && u.Country.Contains(country)
               && u.Region.Contains(region)
               && u.City.Contains(city)
               && u.SubscriptionExecutorExpiresDate > DateTime.Now);
        }

        /// <summary>
        ///   Get files from open source by id. 
        /// </summary>
        /// <param name="ownerOpenSourceId">Id of owner of openSource.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Files from open source.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">User have not permissions to get files.</exception>

        public async Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId)
                ?? throw new UnauthorizedAccessException();

            user = user.SubscriptionOpenSourceExpiresDate > DateTime.Now
                ? user
                : throw new UnauthorizedAccessException();

            return _context.Attachment
                .Join(_context.Users,
                    a => a.ContainerId,
                    u => u.Id,
                    (a, u) => new FileToReturnModel()
                    {
                        Id = a.Id,
                        ContainerId = u.Id,
                        ContainerName = a.ContainerName,
                        Name = a.Name,
                        Link = a.Link,
                        Type = a.Type
                    })
                 .Where(ftr => ftr.ContainerName.Equals(Defines.AttachmentContainerName.USER));
        }

        /// <summary>
        ///   Download file by id. 
        /// </summary>
        /// <param name="fileId">Id of file to download.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    File to download.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">User have not permissions to get file.</exception>

        public async Task<FileToReturnModel> OpenSourceDownloadFile(long fileId, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId)
                ?? throw new UnauthorizedAccessException();

            user = user.SubscriptionOpenSourceExpiresDate > DateTime.Now
                ? user
                : throw new UnauthorizedAccessException();

            return _context.Attachment
                .Join(_context.Users,
                    a => a.ContainerId,
                    u => u.Id,
                    (a, u) => new FileToReturnModel()
                    {
                        Id = a.Id,
                        ContainerId = u.Id,
                        ContainerName = a.ContainerName,
                        Name = a.Name,
                        Link = a.Link,
                        Type = a.Type
                    })
                 .FirstOrDefault(ftr => ftr.ContainerName.Equals(Defines.AttachmentContainerName.USER)
                    && ftr.Id == fileId);
        }

        /// <summary>
        ///   Validate email address. 
        /// </summary>
        /// <param name="validationCode">Validation code of email.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    True - if validation code right, else - false.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">User not found.</exception>

        public async Task<User> ValidateEmail(string validationCode, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            user.EmailIsValidated = user.EmailIsValidated == true
                ? throw new InvalidOperationException()
                : validationCode.ValidateCode(user.Email);

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Change password of current user. 
        /// </summary>
        /// <param name="oldPassword">Old password of user.</param>
        /// <param name="newPassword">New password of user.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    true - password changed, false - oldpassword incorrect
        /// </returns>

        public async Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            var userPassword = _context.UserPasswords.FirstOrDefault(up => up.UserId == user.Id)
                ?? throw new ArgumentNullException();

            if (!userPassword.Password.VerifyHashedPassword(oldPassword))
            {
                throw new InvalidOperationException();
            }

            userPassword.Password = newPassword.HashPassword();

            userPassword = await _userPasswordRepository.EditAsync(userPassword);

            return true;
        }

        /// <summary>
        ///   Change description of user. 
        /// </summary>
        /// <param name="description">Description model of user.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Changed model of current user.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user id of description != current user id.</exception>

        public async Task<User> EditProfile(User user, long currentUserId)
        {
            user = (await _userRepository.GetAsync(currentUserId)).Id == user.Id
                ? await _userRepository.EditAsync(user)
                : throw new UnauthorizedAccessException();

            return user;
        }

        /// <summary>
        ///   Add picture of user profile. 
        /// </summary>
        /// <param name="file">Picture to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added image.
        /// </returns>

        public async Task<User> AddPictureProfile(FileToAddModel file, string currentUrl, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            user.PictureLink = FileStorage.UploadFile(file, currentUrl, Defines.FileFolders.USER_PICTURES_FOLDER).Link;

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Remove picture of user profile. 
        /// </summary>
        /// <param name="id">Id of picture to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed image.
        /// </returns>

        public async Task<User> RemovePictureProfile(long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            user.PictureLink = null;

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Add request to buy subscription(executor/opensource validate by cost). 
        /// </summary>
        /// <param name="cost">Cost of subscription.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    User.
        /// </returns>

        public async Task<User> BuySubscription(string name, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            switch (name)
            {
                case Defines.Subscription.EXECUTOR:
                    {
                        user.SubscriptionExecutorExpiresDate = DateTime.Now.AddMonths(Defines.Subscription.COUNT_MONTH);
                        user = await _userRepository.EditAsync(user);
                    }
                    break;
                case Defines.Subscription.OPEN_SOURSE:
                    {
                        user.SubscriptionOpenSourceExpiresDate = DateTime.Now.AddMonths(Defines.Subscription.COUNT_MONTH);
                        user = await _userRepository.EditAsync(user);
                    }
                    break;
                default: break;
            }

            return user;
        }

        /// <summary>
        ///   Add file to open source area of user. 
        /// </summary>
        /// <param name="file">File to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added file.
        /// </returns>

        public async Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file, string currentUrl, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            var savedFile = FileStorage.UploadFile(file, currentUrl, Defines.FileFolders.OPENSOURCE_ATTACHMENT_FOLDER);

            var addedAttachment = await _attachmentRepository.AddAsync(new Attachment()
            {
                ContainerId = user.Id,
                ContainerName = Defines.AttachmentContainerName.USER,
                Link = savedFile.Link,
                Name = savedFile.Name,
                Type = savedFile.Type
            });

            savedFile.Id = addedAttachment.Id;

            return savedFile;
        }

        /// <summary>
        ///   Remove file to open source area of user. 
        /// </summary>
        /// <param name="file">File to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed file.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user id of file != current user id.</exception>

        public async Task<FileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            var attachment = await _attachmentRepository.GetAsync(id);

            attachment = attachment.ContainerId == user.Id
                && attachment.ContainerName == Defines.AttachmentContainerName.USER
                ? await _attachmentRepository.RemoveAsync(attachment.Id)
                : throw new UnauthorizedAccessException();

            return new FileToReturnModel
            {
                Id = attachment.Id,
                ContainerId = attachment.ContainerId,
                ContainerName = attachment.ContainerName,
                Link = attachment.Link,
                Name = attachment.Name,
                Type = attachment.Type
            };
        }

        /// <summary>
        ///   Add order to area. 
        /// </summary>
        /// <param name="file">Order to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added order.
        /// </returns>

        public async Task<Order> AddOrder(Order order, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add executor to order. 
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <param name="executorUserId">Id of executor.</param>
        /// <returns>
        ///    Updated order.
        /// </returns>

        public async Task<Order> StartExecuteOrder(long id, long executorUserId, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Refuse executor to start execute order. 
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Updated order.
        /// </returns>

        public async Task<Order> RefuseExecutor(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Close execute of order from Executor.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///   Requested order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user not found or not permissions.</exception>

        public async Task<Order> CloseOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add review to executor. 
        /// </summary>
        /// <param name="review">Review to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added review.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">User not permissions.</exception>

        public async Task<Review> AddReview(Review review, long currentUserId)
        {
            throw new Exception();
        }
    }
}
