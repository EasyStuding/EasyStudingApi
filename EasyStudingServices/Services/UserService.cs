using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingModels.Extensions;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request.
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
            return _userRepository.GetUsers(education.ConvertToValidModel(),
                country.ConvertToValidModel(),
                region.ConvertToValidModel(),
                city.ConvertToValidModel());
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
            return await _userRepository.GetUser(id);
        }

        /// <summary>
        ///   Get orders of current user. 
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Orders.
        /// </returns>

        public async Task<IQueryable<OrderToReturn>> GetOrders(long currentUserId)
        {
            return await _userRepository.GetOrders(currentUserId);
        }

        /// <summary>
        ///   Get order of current user by id. 
        /// </summary>
        /// <param name="id">Id of current user order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Order.
        /// </returns>

        public async Task<OrderToReturn> GetOrder(long id, long currentUserId)
        {
            return await _userRepository.GetOrder(id, currentUserId);
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
            return _userRepository.GetExecutors(education.ConvertToValidModel(),
                country.ConvertToValidModel(),
                region.ConvertToValidModel(),
                city.ConvertToValidModel());
        }

        /// <summary>
        ///   Get files from open source by id. 
        /// </summary>
        /// <param name="ownerOpenSourceId">Id of owner of openSource.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Files from open source.
        /// </returns>

        public async Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId, long currentUserId)
        {
            return await _userRepository.GetOpenSourceAttachments(ownerOpenSourceId, currentUserId);
        }

        /// <summary>
        ///   Download file by id. 
        /// </summary>
        /// <param name="fileId">Id of file to download.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    File to download.
        /// </returns>

        public async Task<FileToReturnModel> OpenSourceDownloadFile(long fileId, long currentUserId)
        {
            return await _userRepository.OpenSourceDownloadFile(fileId, currentUserId);
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

        public async Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            return await _userRepository.ChangePassword(oldPassword ?? throw new ArgumentException(),
                newPassword.IsValidPassword() ? newPassword : throw new ArgumentException(),
                currentUserId);
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

        public async Task<User> EditProfile(User user, long currentUserId)
        {
            user.CheckArgumentException();

            return await _userRepository.EditProfile(user, currentUserId);
        }


        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
        /// <param name="validateModel">Model of validation user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

        public async Task<User> ValidateEmail(ValidateModel validateModel, long currentUserId)
        {
            validateModel.CheckArgumentException();

            var userEntity = await _userRepository.ValidateEmail(validateModel, currentUserId);

            return userEntity;
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
            var user = await _userRepository.GetUser(currentUserId);

            MailService.Send(user.Email, _userRepository.GetValidationCode(user.Email));

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

            return await _userRepository.AddPictureProfile(file, currentUrl, currentUserId);
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
            return await _userRepository.RemovePictureProfile(currentUserId);
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
            return await _userRepository.BuySubscription(name.IsValidSubscription() ? name : throw new ArgumentException(),
                currentUserId);
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

            return await _userRepository.AddFileToOpenSource(file, currentUrl, currentUserId);
        }

        /// <summary>
        ///   Remove file to open source area of user. 
        /// </summary>
        /// <param name="file">File to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed file.
        /// </returns>

        public async Task<FileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId)
        {
            return await _userRepository.RemoveFileFromOpenSource(id, currentUserId);
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

        public async Task<OrderToReturn> AddOrder(OrderToAdd order, string currentUrl, long currentUserId)
        {
            order.CheckArgumentException();

            return await _userRepository.AddOrder(order, currentUrl, currentUserId);
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
            return await _userRepository.StartExecuteOrder(id, executorUserId, currentUserId);
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
            return await _userRepository.RefuseExecutor(id, currentUserId);
        }

        /// <summary>
        ///   Close execute of order from Executor.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///   Requested order.
        /// </returns>

        public async Task<OrderToReturn> CloseOrder(long id, long currentUserId)
        {
            return await _userRepository.CloseOrder(id, currentUserId);
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

        public async Task<Review> AddReview(Review review, long currentUserId)
        {
            review.CheckArgumentException();

            return await _userRepository.AddReview(review, currentUserId);
        }
    }
}
