using EasyStudingModels.Models;
using System;
using System.Collections.Generic;

namespace EasyStudingUnitTests.TestData
{

    public class FakeData
    {
        public User User { get; set; }
        public IEnumerable<User> Users { get; set; }
        public Order Order { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public Skill Skill { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public UserSkill UserSkill { get; set; }
        public IEnumerable<UserSkill> UserSkills { get; set; }
        public FakeData()
        {
            InitializeUserRepositoryData();
            InitializeOrderRepositoryData();
            InitializeSkillRepositoryData();
            InitializeUserSkillRepositoryData();

        }
        private void InitializeUserRepositoryData()
        {
            User = new User
            {
                Id = 1,
                FullName = "Jon Snown",
                Description = "King of north",
                BanExpiresDate = null,
                City = "Winteful",
                Country = "Westeros",
                Education = "High",
                Email = "jon@mail.ru",
                EmailIsValidated = null,
                PictureLink = "",
                Raiting = 10,
                Region = "Brest",
                RegistrationDate = DateTime.Now,
                Role = "user",
                SubscriptionExecutorExpiresDate = null,
                SubscriptionOpenSourceExpiresDate = null,
                TelephoneNumber = "3245667",
                TelephoneNumberIsValidated = null,
                UserIsGaranted = null
            };
            Users = new User[]
            {
                User,
                new User
                {
                    Id = 1,
                    FullName = "Aria Stark",
                    Description = "King of north",
                    BanExpiresDate = null,
                    City = "Winteful",
                    Country = "Westeros",
                    Education = "High",
                    Email = "aria@mail.ru",
                    EmailIsValidated = null,
                    PictureLink = "",
                    Raiting = 9,
                    Region = "Brest",
                    RegistrationDate = DateTime.Now,
                    Role = "user",
                    SubscriptionExecutorExpiresDate = null,
                    SubscriptionOpenSourceExpiresDate = null,
                    TelephoneNumber = "3245669",
                    TelephoneNumberIsValidated = null,
                    UserIsGaranted = null
                }
            };
        }
        private void InitializeOrderRepositoryData()
        {
            Order = new Order
            {
                Id = 1,
                CustomerId = 1,
                ExecutorId = 1,
                Cost = 100,
                InProgress = false,
                IsCompleted = true,
                Description = "Batle whith Serseya",
                Title = "Died Serseya",
                IsClosedByCustomer = true,
                IsClosedByExecutor = true
            };
            Orders = new Order[]
            {
                Order,
                new Order
                {
                    Id=2,
                    CustomerId=2,
                    ExecutorId=1,
                    Cost=150,
                    InProgress=false,
                    IsCompleted=true,
                    Description="Batle whith Jofry",
                    Title="Died Jofry",
                    IsClosedByCustomer=true,
                    IsClosedByExecutor=true
                },
                new Order
                {
                    Id=3,
                    CustomerId=2,
                    ExecutorId=2,
                    Cost=150,
                    InProgress=false,
                    IsCompleted=true,
                    Description="Batle whith Jofry",
                    Title="Died Jofry",
                    IsClosedByCustomer=true,
                    IsClosedByExecutor=true
                }
            };
        }

        private void InitializeSkillRepositoryData()
        {
            Skill = new Skill
            {
                Id = 1,
                Name = "Math"
            };

            Skills = new Skill[]
            {
                Skill,
                new Skill
                {
                    Id=2,
                    Name="Physics"
                },
                new Skill
                {
                    Id=3,
                    Name="Programming"
                }
            };
        }

        private void InitializeUserSkillRepositoryData()
        {
            UserSkill = new UserSkill
            {
                Id = 1,
                UserId = 1,
                SkillId = 1
            };
            UserSkills = new UserSkill[]
            {
                UserSkill,
                new UserSkill
                {
                    Id=2,
                    UserId=1,
                    SkillId=2
                },
                new UserSkill
                {
                    Id=3,
                    UserId=2,
                    SkillId=2
                }
            };
        }

    }
}
