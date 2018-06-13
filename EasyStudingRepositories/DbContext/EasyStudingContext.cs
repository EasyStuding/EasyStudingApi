using Microsoft.EntityFrameworkCore;
using EasyStudingModels.DbContextModels;

namespace EasyStudingRepositories.DbContext
{
    public partial class EasyStudingContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=easystuding;Username=postgres;Password=admin";

        public EasyStudingContext()
        {
        }

        public EasyStudingContext(DbContextOptions<EasyStudingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<BanDescription> BanDescriptions { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<EducationType> EducationTypes { get; set; }
        public virtual DbSet<EducationUserDecription> EducationUserDecriptions { get; set; }
        public virtual DbSet<EmailDescription> EmailDescriptions { get; set; }
        public virtual DbSet<ExecutorSkill> ExecutorSkills { get; set; }
        public virtual DbSet<OpenSource> OpenSources { get; set; }
        public virtual DbSet<OpenSourceAttachment> OpenSourceAttachments { get; set; }
        public virtual DbSet<OrderAttachment> OrderAttachment { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderSkill> OrderSkills { get; set; }
        public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<SubscriptionExecutor> SubscriptionExecutors { get; set; }
        public virtual DbSet<SubscriptionOpenSource> SubscriptionOpenSources { get; set; }
        public virtual DbSet<UserDescription> UserDescriptions { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<UserPicture> UserPictures { get; set; }
        public virtual DbSet<UserRegistration> UserRegistrations { get; set; }
        public virtual DbSet<ValidationEmail> ValidationEmails { get; set; }
        public virtual DbSet<ValidationUser> ValidationUsers { get; set; }
        public virtual DbSet<CloseTransaction> CloseTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConnectionString);
            }
        }

        #region Registration of Models
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("attachments");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasColumnName("href");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<BanDescription>(entity =>
            {
                entity.ToTable("bandescriptions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.ExpiresDate)
                    .HasColumnName("dateexpires")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserInformationId).HasColumnName("userinformationid");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("cities");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CountryId).HasColumnName("countryid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.ToTable("costs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("educations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.EducationTypeId).HasColumnName("educationtypeid");

                entity.Property(e => e.EducationName)
                    .IsRequired()
                    .HasColumnName("nameofeducation");

                entity.Property(e => e.CityId).HasColumnName("cityid");
            });

            modelBuilder.Entity<EducationType>(entity =>
            {
                entity.ToTable("educationtypes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("typename");
            });

            modelBuilder.Entity<EducationUserDecription>(entity =>
            {
                entity.ToTable("educationuserdecriptions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.AdmissionDate)
                    .HasColumnName("admissiondate")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EducationId).HasColumnName("educationid");

                entity.Property(e => e.GraduationDate)
                    .HasColumnName("graduationdate")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<EmailDescription>(entity =>
            {
                entity.ToTable("emaildescriptions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.IsValidated)
                    .HasColumnName("isvalidated")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<ExecutorSkill>(entity =>
            {
                entity.ToTable("executorskills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.SkillId).HasColumnName("skillid");

                entity.Property(e => e.SubscriptionExecutorId).HasColumnName("subscriptionexecutorid");
            });

            modelBuilder.Entity<OpenSource>(entity =>
            {
                entity.ToTable("opensources");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.OpenSourceSubscriptionId).HasColumnName("opensourcesubscriptionid");
            });

            modelBuilder.Entity<OpenSourceAttachment>(entity =>
            {
                entity.ToTable("opensourceattachments");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.AttachmentId).HasColumnName("attachmentid");

                entity.Property(e => e.OpenSourceId).HasColumnName("opensourceid");
            });

            modelBuilder.Entity<OrderAttachment>(entity =>
            {
                entity.ToTable("orderattachments");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.AttachmentId).HasColumnName("attachmentid");

                entity.Property(e => e.OrderId).HasColumnName("orderid");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.ToTable("orderdetails");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CustomerId).HasColumnName("customerid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.ExecutorId).HasColumnName("executorid");

                entity.Property(e => e.StateId).HasColumnName("stateid");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OrderSkill>(entity =>
            {
                entity.ToTable("orderskills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.OrderId).HasColumnName("orderid");

                entity.Property(e => e.SkillId).HasColumnName("skillid");
            });

            modelBuilder.Entity<PaymentTransaction>(entity =>
            {
                entity.ToTable("paymenttransactions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CostId).HasColumnName("costid");

                entity.Property(e => e.IsPaid)
                    .HasColumnName("ispaid")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UserinformationId).HasColumnName("userinformationid");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("reviews");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Raiting).HasColumnName("raiting");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.ReviewOwnerId).HasColumnName("reviewownerid");

                entity.Property(e => e.ReviewRecipientId).HasColumnName("reviewrecipientid");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("states");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.InProgress)
                    .HasColumnName("inprogress")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("iscompleted")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<SubscriptionExecutor>(entity =>
            {
                entity.ToTable("subscriptionexecutors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CostId).HasColumnName("costid");

                entity.Property(e => e.DateExpires)
                    .HasColumnName("dateexpires")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<SubscriptionOpenSource>(entity =>
            {
                entity.ToTable("subscriptionopensources");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CostId).HasColumnName("costid");

                entity.Property(e => e.DateExpires)
                    .HasColumnName("dateexpires")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<UserDescription>(entity =>
            {
                entity.ToTable("userdescriptions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CityId).HasColumnName("cityid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EducationUserDecriptionId).HasColumnName("educationuserdecriptionid");

                entity.Property(e => e.EmailDescriptionId).HasColumnName("emaildescriptionid");

                entity.Property(e => e.FirstName).HasColumnName("firstname");

                entity.Property(e => e.LastName).HasColumnName("lastname");

                entity.Property(e => e.UserInformationId).HasColumnName("userinformationid");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.ToTable("userinformations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.IsBanned)
                    .HasColumnName("isbanned")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsFreeTrial)
                    .HasColumnName("isfreetrial")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsGaranted)
                    .HasColumnName("isgaranted")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasColumnName("loginname");

                entity.Property(e => e.OpenSourceId).HasColumnName("opensourceid");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("roleid");

                entity.Property(e => e.SubscriptionExecutorId).HasColumnName("subscriptionexecutorid");

                entity.Property(e => e.UserRegistrationId).HasColumnName("userregistrationid");
            });

            modelBuilder.Entity<UserPicture>(entity =>
            {
                entity.ToTable("userpictures");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasColumnName("ref");

                entity.Property(e => e.UserInformationId).HasColumnName("userinformationid");
            });

            modelBuilder.Entity<UserRegistration>(entity =>
            {
                entity.ToTable("userregistrations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.IsValidated)
                    .HasColumnName("isvalidated")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("registrationdate")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.TelephoneNumber)
                    .IsRequired()
                    .HasColumnName("telephonenumber");
            });

            modelBuilder.Entity<ValidationEmail>(entity =>
            {
                entity.ToTable("validationemails");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.EmailDescriptionId).HasColumnName("emaildescriptionid");

                entity.Property(e => e.ValidateCode)
                    .IsRequired()
                    .HasColumnName("validatecode");
            });

            modelBuilder.Entity<ValidationUser>(entity =>
            {
                entity.ToTable("validationusers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.UserRegistrationId).HasColumnName("userregistrationid");

                entity.Property(e => e.ValidationCode)
                    .IsRequired()
                    .HasColumnName("validationcode");
            });

            modelBuilder.Entity<CloseTransaction>(entity =>
            {
                entity.ToTable("closetransactions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.OrderDetailsId).HasColumnName("orderdetailsid");

                entity.Property(e => e.IsClosedByCustomer)
                    .IsRequired()
                    .HasColumnName("isclosedbycustomer");

                entity.Property(e => e.IsClosedByExecutor)
                    .IsRequired()
                    .HasColumnName("isclosedbyexecutor");
            });
        }
        #endregion
    }
}
