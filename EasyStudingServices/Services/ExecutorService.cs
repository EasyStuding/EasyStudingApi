﻿using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingModels.Extensions;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingServices.Extensions;
using System;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request. 
    //In this service you need currentUserId to check permissons and create/close orders, role of user not contains in identity.
    public class ExecutorService: IExecutorService
    {
        #region Initialize repositories.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Skill> _skillRepository;
        private readonly IRepository<UserSkill> _userSkillRepository;
        private readonly IRepository<OrderSkill> _orderSkillRepository;
        private readonly IRepository<Attachment> _attachmentRepository;

        public ExecutorService(
            IRepository<User> userRepository,
            IRepository<Order> orderRepository,
            IRepository<Skill> skillRepository,
            IRepository<UserSkill> userSkillRepository,
            IRepository<OrderSkill> orderSkillRepository,
            IRepository<Attachment> attachmentRepository
            )
        {
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _skillRepository = skillRepository;
            _userSkillRepository = userSkillRepository;
            _orderSkillRepository = orderSkillRepository;
            _attachmentRepository = attachmentRepository;
        }

        #endregion

        /// <summary>
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        ///   If orders have executor, then not return them.
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="country">Country of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<IQueryable<OrderToReturn>> GetOrders(string education, string country, string region, string city, string skills, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var skillsArr = skills?.Split(',');

            var users = _userRepository.GetAll().Where(u =>
               (string.IsNullOrWhiteSpace(education) || education.Contains(u.Education))
               && (string.IsNullOrWhiteSpace(country) || country.Equals(u.Country))
               && (string.IsNullOrWhiteSpace(region) || region.Equals(u.Region))
               && (string.IsNullOrWhiteSpace(city) || city.Equals(u.City))
               && u.TelephoneNumberIsValidated == true);

            return _orderRepository.GetAll().Where(o =>
                o.ExecutorId == null
                && users.Any(u =>
                    u.Id == o.CustomerId))
                .ToArray()
                .Select(o => ConvertOrder(o))
                .Where(u => string.IsNullOrWhiteSpace(skills) ? true : u.Skills.Select(s => s.Name).Intersect(skillsArr).Any())
                .AsQueryable();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<OrderToReturn> GetOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            return ConvertOrder(await _orderRepository.GetAsync(id));
        }

        /// <summary>
        ///   Open transaction to get rights to perform order.
        /// </summary>
        /// <param name="id">Id of order to get rights for this order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.InvalidOperationException">When order have executor.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Id of executor != currentUserId 
        /// or current user not executor.</exception>

        public async Task<OrderToReturn> GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var order = await _orderRepository.GetAsync(id);

            order.ExecutorId = (order.ExecutorId == null
                && order.InProgress == false)
                ? currentUserId
                : throw new InvalidOperationException();

            return ConvertOrder(await _orderRepository.EditAsync(order));
        }

        /// <summary>
        ///   Close execute of order from Executor.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///   Requested order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor 
        /// or executor of order not current user.</exception>

        public async Task<OrderToReturn> CloseOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var order = await _orderRepository.GetAsync(id);

            order.IsClosedByExecutor = (order.ExecutorId == currentUserId
                && order.InProgress == true)
                ? true
                : throw new UnauthorizedAccessException();

            order.IsCompleted = order.IsClosedByCustomer == true
                ? true
                : false;

            return ConvertOrder(await _orderRepository.EditAsync(order));
        }

        /// <summary>
        ///   Add skill to executor profile.
        /// </summary>
        /// <param name="id">Id of skill what executor want to add.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Added skill.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Skill> AddSkill(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var skill = await _skillRepository.GetAsync(id);

            await _userSkillRepository.AddAsync(new UserSkill()
            {
                SkillId = skill.Id,
                UserId = currentUserId
            });

            return skill;
        }

        /// <summary>
        ///   Romove skill from executor profile.
        /// </summary>
        /// <param name="id">Id of skill what executor want to remove.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Removed skill.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>
        /// <exception cref="System.ArgumentNullException">Result not found.</exception>

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var skill = await _skillRepository.GetAsync(id);

            var userSkill = _userSkillRepository
                .GetAll()
                .FirstOrDefault(us => us.SkillId == skill.Id
                    && us.UserId == currentUserId)
                ?? throw new ArgumentNullException();

            await _userSkillRepository.RemoveAsync(userSkill.Id);

            return skill;
        }

        private OrderToReturn ConvertOrder(Order order)
        {
            return order
                .ConvertOrderToReturn(order.GetAttachmentsToOrder(_attachmentRepository),
                order.GetSkillsToOrder(_orderSkillRepository, _skillRepository));
        }
    }
}
