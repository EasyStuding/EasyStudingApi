using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using System;
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
            throw new Exception();
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
            throw new Exception();
        }

        /// <summary>
        ///   Get orders of current user. 
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Orders.
        /// </returns>

        public async Task<IQueryable<Order>> GetOrders(long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get order of current user by id. 
        /// </summary>
        /// <param name="id">Id of current user order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user not found or Customer of order != current user.</exception>

        public async Task<Order> GetOrder(long id, long currentUserId)
        {
            throw new Exception();
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
            throw new Exception();
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
            throw new Exception();
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
            throw new Exception();
        }

        /// <summary>
        ///   Validate email address. 
        /// </summary>
        /// <param name="validationCode">Validation code of email.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    True - if validation code right, else - false.
        /// </returns>

        public async Task<bool> ValidateEmail(string validationCode, long currentUserId)
        {
            throw new Exception();
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
            throw new Exception();
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
            throw new Exception();
        }

        /// <summary>
        ///   Add picture of user profile. 
        /// </summary>
        /// <param name="file">Picture to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added image.
        /// </returns>

        public async Task<FileToReturnModel> AddPictureProfile(FileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove picture of user profile. 
        /// </summary>
        /// <param name="id">Id of picture to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed image.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user id of photo != current user id.</exception>

        public async Task<FileToReturnModel> RemovePictureProfile(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add request to buy subscription(executor/opensource validate by cost). 
        /// </summary>
        /// <param name="cost">Cost of subscription.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Cost of subscription.
        /// </returns>

        public async Task<User> BuySubscription(string name, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add file to open source area of user. 
        /// </summary>
        /// <param name="file">File to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added file.
        /// </returns>

        public async Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove file to open source area of user. 
        /// </summary>
        /// <param name="file">File to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed file.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">When user id of photo != current user id.</exception>

        public async Task<FileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId)
        {
            throw new Exception();
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
