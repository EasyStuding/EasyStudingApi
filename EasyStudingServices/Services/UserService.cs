using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingModels.Extensions;
using System.Collections.Generic;
using EasyStudingModels;
using EasyStudingRepositories.DbContext;
using EasyStudingServices.Extensions;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request.
    public class UserService: IUserService
    {
        #region Initialize repositories.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<UserPassword> _userPasswordRepository;
        private readonly IRepository<Attachment> _attachmentRepository;
        private readonly IRepository<Review> _reviewRepository;
        private readonly IRepository<Skill> _skillRepository;

        private readonly EasyStudingContext _context;

        public UserService(IRepository<User> userRepository,
            IRepository<Order> orderRepository,
            IRepository<UserPassword> userPasswordRepository,
            IRepository<Attachment> attachmentRepository,
            IRepository<Review> reviewRepository,
            IRepository<Skill> skillRepository,
            EasyStudingContext context)
        {
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _userPasswordRepository = userPasswordRepository;
            _attachmentRepository = attachmentRepository;
            _reviewRepository = reviewRepository;
            _skillRepository = skillRepository;
        }

        #endregion

        /// <summary>
        ///   Get skills. 
        /// </summary>
        /// <returns>
        ///    Skills.
        /// </returns>

        public IQueryable<Skill> GetSkills()
        {
            return _skillRepository.GetAll();
        }

        /// <summary>
        ///   Get skill. 
        /// </summary>
        /// <param name="id">Id of skill.</param>
        /// <returns>
        ///    Skill.
        /// </returns>

        public async Task<Skill> GetSkill(long id)
        {
            return await _skillRepository.GetAsync(id);
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
               u.Education.Contains(education.ConvertToValidModel())
               && u.Country.Contains(country.ConvertToValidModel())
               && u.Region.Contains(region.ConvertToValidModel())
               && u.City.Contains(city.ConvertToValidModel()));
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

        public async Task<IQueryable<OrderToReturn>> GetOrders(long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId)
                ?? throw new UnauthorizedAccessException();

            var orders = _orderRepository
                .GetAll()
                .Where(o => o.CustomerId == user.Id || o.ExecutorId == user.Id)
                .Select(o => new OrderToReturn
                {
                    Id = o.Id,
                    InProgress = o.InProgress,
                    CustomerId = o.CustomerId,
                    Description = o.Description,
                    ExecutorId = o.ExecutorId,
                    IsClosedByCustomer = o.IsClosedByCustomer,
                    IsClosedByExecutor = o.IsClosedByExecutor,
                    IsCompleted = o.IsCompleted,
                    Title = o.Title
                });

            foreach (var order in orders)
            {
                order.Attachments = GetAttachmentsToOrder(order);
            }

            return orders;
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

        public async Task<OrderToReturn> GetOrder(long id, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId)
                ?? throw new UnauthorizedAccessException();

            var order = _orderRepository
                .GetAll()
                .FirstOrDefault(o => o.Id == id
                && (o.CustomerId == user.Id || o.ExecutorId == user.Id));

            return ConvertOrderToReturn(order, GetAttachmentsToOrder(order));
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
               u.Education.Contains(education.ConvertToValidModel())
               && u.Country.Contains(country.ConvertToValidModel())
               && u.Region.Contains(region.ConvertToValidModel())
               && u.City.Contains(city.ConvertToValidModel())
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
            var user = await _userRepository.GetAsync(currentUserId);

            user = user.SubscriptionOpenSourceExpiresDate > DateTime.Now
                || user.Id == ownerOpenSourceId
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
        ///   Change password of current user. 
        /// </summary>
        /// <param name="oldPassword">Old password of user.</param>
        /// <param name="newPassword">New password of user.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    true - password changed, false - oldpassword incorrect
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.InvalidOperationException">OldPassword not the same with old userPassowrd.</exception>

        public async Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            oldPassword = oldPassword.IsValidPassword()
                ? oldPassword
                : throw new ArgumentException();

            newPassword = newPassword.IsValidPassword()
                ? newPassword
                : throw new ArgumentException();

            var user = await _userRepository.GetAsync(currentUserId);

            var userPassword = _userPasswordRepository.GetAll().FirstOrDefault(up => up.UserId == user.Id)
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
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.UnauthorizedAccessException">When user id of description != current user id.</exception>

        public async Task<User> EditProfile(User user, long currentUserId)
        {
            user.CheckArgumentException();

            var _user = await _userRepository.GetAsync(user.Id);

            _user = _user.Id == currentUserId
                ? _user
                : throw new UnauthorizedAccessException();

            user.BanExpiresDate = _user.BanExpiresDate;
            user.SubscriptionExecutorExpiresDate = _user.SubscriptionExecutorExpiresDate;
            user.SubscriptionOpenSourceExpiresDate = _user.SubscriptionOpenSourceExpiresDate;
            user.RegistrationDate = _user.RegistrationDate;

            user.EmailIsValidated = user.Email.Equals(_user.Email)
                ? _user.EmailIsValidated
                : false;

            user.TelephoneNumberIsValidated = _user.TelephoneNumber.Equals(_user.TelephoneNumber)
                ? _user.TelephoneNumberIsValidated
                : false;

            user.PictureLink = _user.PictureLink;
            user.Role = _user.Role;

            user.UserIsGaranted = _user.UserIsGaranted;
            user.Raiting = _user.Raiting;

            return await _userRepository.EditAsync(user);
        }


        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
        /// <param name="validateModel">Model of validation user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.UnauthorizedAccessException">When user id of description != current user id.</exception>

        public async Task<User> ValidateEmail(ValidateModel validateModel, long currentUserId)
        {
            validateModel.CheckArgumentException();

            var user = await _userRepository.GetAsync(validateModel.UserId);

            user.EmailIsValidated = user.Id == currentUserId ?
                validateModel.ValidationCode.ValidateCode(user.Email)
                : throw new UnauthorizedAccessException();

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Get validation code to email.
        /// </summary>
        /// <param name="user">User to validate.</param>
        /// <returns>
        ///    True or exception.
        /// </returns>

        public async Task<bool> GetValidationCode(long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            MailService.Send(user.Email);

            return true;
        }

        /// <summary>
        ///   Add picture of user profile. 
        /// </summary>
        /// <param name="file">Picture to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added image.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<User> AddPictureProfile(FileToAddModel file, string currentUrl, long currentUserId)
        {
            file.CheckArgumentException();

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
        ///    Cost of subscription.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

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
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file, string currentUrl, long currentUserId)
        {
            file.CheckArgumentException();

            var user = await _userRepository.GetAsync(currentUserId);

            var savedFile = FileStorage.UploadFile(file, currentUrl, Defines.FileFolders.OPENSOURCE_ATTACHMENT_FOLDER);

            var addedAttachment = await _attachmentRepository.AddAsync(new Attachment()
            {
                ContainerId = user.Id,
                ContainerName = Defines.AttachmentContainerName.USER,
                Link = savedFile.Link,
                Name = savedFile.Name,
                Type = savedFile.Name.GetContentType()
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
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="InvalidOperationException">When customer id != user id</exception>

        public async Task<OrderToReturn> AddOrder(OrderToAdd order, string currentUrl, long currentUserId)
        {
            order.CheckArgumentException();

            var user = await _userRepository.GetAsync(currentUserId);

            order = order.CustomerId == user.Id
                ? order
                : throw new InvalidOperationException();

            var attachments = await SaveFiles(order.Attachments, currentUrl, Defines.FileFolders.ORDER_ATTACHMENTS_FOLDER);

            var savedOrder = await _orderRepository.AddAsync(order);

            return ConvertOrderToReturn(savedOrder, attachments);
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

        public async Task<OrderToReturn> StartExecuteOrder(long id, long executorUserId, long currentUserId)
        {
            var order = await _orderRepository.GetAsync(id);

            order.InProgress = order.ExecutorId == executorUserId
                && order.CustomerId == currentUserId;

            order = await _orderRepository.EditAsync(order);

            return ConvertOrderToReturn(order, GetAttachmentsToOrder(order));
        }

        /// <summary>
        ///   Refuse executor to start execute order. 
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Updated order.
        /// </returns>

        public async Task<OrderToReturn> RefuseExecutor(long id, long currentUserId)
        {
            var order = await _orderRepository.GetAsync(id);

            order.ExecutorId = (order.CustomerId == currentUserId
                && order.InProgress == false)
                ? null
                : order.ExecutorId;

            order = await _orderRepository.EditAsync(order);

            return ConvertOrderToReturn(order, GetAttachmentsToOrder(order));
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

        public async Task<OrderToReturn> CloseOrder(long id, long currentUserId)
        {
            var user = await _userRepository.GetAsync(currentUserId);

            var order = await _orderRepository.GetAsync(id);

            order.IsClosedByCustomer = order.CustomerId == user.Id
                ? true
                : throw new UnauthorizedAccessException();

            order.IsCompleted = order.IsClosedByCustomer == true
                && order.IsClosedByExecutor == true;

            order = await _orderRepository.EditAsync(order);

            return ConvertOrderToReturn(order, GetAttachmentsToOrder(order));
        }

        /// <summary>
        ///   Add review to executor. 
        /// </summary>
        /// <param name="review">Review to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added review.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>
        /// <exception cref="System.UnauthorizedAccessException">User not permissions.</exception>

        public async Task<Review> AddReview(Review review, long currentUserId)
        {
            review.CheckArgumentException();

            var user = await _userRepository.GetAsync(currentUserId);

            var order = await _orderRepository.GetAsync(review.OrderId);

            order = order.CustomerId == user.Id
                ? order
                : throw new UnauthorizedAccessException();

            return await _reviewRepository.AddAsync(review);
        }

        #region Helpers.

        private IEnumerable<FileToReturnModel> GetAttachmentsToOrder(Order order)
        {
            return _attachmentRepository
                    .GetAll()
                    .Where(a => a.ContainerId == order.Id
                        && a.ContainerName == Defines.AttachmentContainerName.ORDER)
                    .Select(a => new FileToReturnModel
                    {
                        Id = a.Id,
                        ContainerId = a.ContainerId,
                        ContainerName = a.ContainerName,
                        Link = a.Link,
                        Name = a.Name,
                        Type = a.Type
                    })
                    .AsEnumerable();
        }

        private OrderToReturn ConvertOrderToReturn(Order order, IEnumerable<FileToReturnModel> attachments)
        {
            return new OrderToReturn
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                Description = order.Description,
                ExecutorId = order.ExecutorId,
                InProgress = order.InProgress,
                IsClosedByCustomer = order.IsClosedByCustomer,
                IsClosedByExecutor = order.IsClosedByExecutor,
                IsCompleted = order.IsCompleted,
                Title = order.Title,
                Attachments = attachments
            };
        }

        private async Task<IEnumerable<FileToReturnModel>> SaveFiles(IEnumerable<FileToAddModel> files, string currentUrl, string folder)
        {
            var listOfAddedFiles = new List<FileToReturnModel>();

            if (files == null
                || files.Count() == 0)
            {
                return null;
            }

            foreach (var file in files)
            {
                listOfAddedFiles.Add(FileStorage.UploadFile(file, currentUrl, folder));
            }

            foreach (var file in listOfAddedFiles)
            {
                await _attachmentRepository.AddAsync(new Attachment()
                {
                    ContainerId = file.ContainerId,
                    ContainerName = Defines.AttachmentContainerName.ORDER,
                    Link = file.Link,
                    Name = file.Name,
                    Type = file.Name.GetContentType()
                });
            }

            return listOfAddedFiles;
        }

        #endregion
    }
}
