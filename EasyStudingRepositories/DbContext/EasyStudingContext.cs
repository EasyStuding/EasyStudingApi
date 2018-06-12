using Microsoft.EntityFrameworkCore;
using EasyStudingModels.DbContextModels;

namespace EasyStudingRepositories.DbContext
{
    public partial class EasyStudingContext : Microsoft.EntityFrameworkCore.DbContext
    {
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=easystuding;Username=postgres;Password=admin");
            }
        }

        #region Registration of Models
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("attachment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Href)
                    .IsRequired()
                    .HasColumnName("href");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<BanDescription>(entity =>
            {
                entity.ToTable("bandescription");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.DateExpires)
                    .HasColumnName("dateexpires")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserInformationId).HasColumnName("userinformationid");

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.BanDescriptions)
                    .HasForeignKey(d => d.UserInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bandescription_userinformationid_fkey");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CountryId).HasColumnName("countryid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_countryid_fkey");
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.ToTable("cost");

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
                entity.ToTable("country");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("education");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.EducationtypeId).HasColumnName("educationtypeid");

                entity.Property(e => e.Nameofeducation)
                    .IsRequired()
                    .HasColumnName("nameofeducation");

                entity.Property(e => e.CityId).HasColumnName("cityid");

                entity.HasOne(d => d.EducationType)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.EducationtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("education_educationtypeid_fkey");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("education_cityid_fkey");
            });

            modelBuilder.Entity<EducationType>(entity =>
            {
                entity.ToTable("educationtype");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("typename");
            });

            modelBuilder.Entity<EducationUserDecription>(entity =>
            {
                entity.ToTable("educationuserdecription");

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

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.EducationUserDecriptions)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("educationuserdecription_educationid_fkey");
            });

            modelBuilder.Entity<EmailDescription>(entity =>
            {
                entity.ToTable("emaildescription");

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
                entity.ToTable("executorskill");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.SkillId).HasColumnName("skillid");

                entity.Property(e => e.SubscriptionExecutorId).HasColumnName("subscriptionexecutorid");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ExecutorSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("executorskill_skillid_fkey");

                entity.HasOne(d => d.SubscriptionExecutor)
                    .WithMany(p => p.ExecutorSkills)
                    .HasForeignKey(d => d.SubscriptionExecutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("executorskill_subscriptionexecutorid_fkey");
            });

            modelBuilder.Entity<OpenSource>(entity =>
            {
                entity.ToTable("opensource");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.OpenSourceSubscriptionId).HasColumnName("opensourcesubscriptionid");

                entity.HasOne(d => d.OpenSourceSubscription)
                    .WithMany(p => p.OpenSource)
                    .HasForeignKey(d => d.OpenSourceSubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("opensource_opensourcesubscriptionid_fkey");
            });

            modelBuilder.Entity<OpenSourceAttachment>(entity =>
            {
                entity.ToTable("opensourceattachment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.AttachmentId).HasColumnName("attachmentid");

                entity.Property(e => e.OpenSourceId).HasColumnName("opensourceid");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.OpenSourceAttachments)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("opensourceattachment_attachmentid_fkey");

                entity.HasOne(d => d.OpenSource)
                    .WithMany(p => p.OpenSourceAttachments)
                    .HasForeignKey(d => d.OpenSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("opensourceattachment_opensourceid_fkey");
            });

            modelBuilder.Entity<OrderAttachment>(entity =>
            {
                entity.ToTable("orderattachment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.AttachmentId).HasColumnName("attachmentid");

                entity.Property(e => e.OrderId).HasColumnName("orderid");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.OrderAttachments)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderattachment_attachmentid_fkey");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderAttachments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderattachment_orderid_fkey");
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

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderDetailsCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderdetails_customerid_fkey");

                entity.HasOne(d => d.Executor)
                    .WithMany(p => p.OrderDetailsExecutors)
                    .HasForeignKey(d => d.ExecutorId)
                    .HasConstraintName("orderdetails_executorid_fkey");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderdetails_stateid_fkey");
            });

            modelBuilder.Entity<OrderSkill>(entity =>
            {
                entity.ToTable("orderskill");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.OrderId).HasColumnName("orderid");

                entity.Property(e => e.SkillId).HasColumnName("skillid");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderSkills)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderskill_orderid_fkey");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.OrderSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderskill_skillid_fkey");
            });

            modelBuilder.Entity<PaymentTransaction>(entity =>
            {
                entity.ToTable("paymenttransaction");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.CostId).HasColumnName("costid");

                entity.Property(e => e.IsPaid)
                    .HasColumnName("ispaid")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UserinformationId).HasColumnName("userinformationid");

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.PaymentTransactions)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paymenttransaction_costid_fkey");

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.PaymentTransactions)
                    .HasForeignKey(d => d.UserinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paymenttransaction_userinformationid_fkey");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

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

                entity.Property(e => e.UserInformationId).HasColumnName("userinformationid");

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("review_userinformationid_fkey");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skill");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("state");

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
                entity.ToTable("subscriptionexecutor");

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

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.SubscriptionExecutors)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subscriptionexecutor_costid_fkey");
            });

            modelBuilder.Entity<SubscriptionOpenSource>(entity =>
            {
                entity.ToTable("subscriptionopensource");

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

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.SubscriptionOpenSources)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subscriptionopensource_costid_fkey");
            });

            modelBuilder.Entity<UserDescription>(entity =>
            {
                entity.ToTable("userdescription");

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

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserDescriptions)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("userdescription_cityid_fkey");

                entity.HasOne(d => d.EducationUserDecription)
                    .WithMany(p => p.UserDescriptions)
                    .HasForeignKey(d => d.EducationUserDecriptionId)
                    .HasConstraintName("userdescription_educationuserdecriptionid_fkey");

                entity.HasOne(d => d.EmailDescription)
                    .WithMany(p => p.UserDescriptions)
                    .HasForeignKey(d => d.EmailDescriptionId)
                    .HasConstraintName("userdescription_emaildescriptionid_fkey");

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.UserDescriptions)
                    .HasForeignKey(d => d.UserInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userdescription_userinformationid_fkey");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.ToTable("userinformation");

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

                entity.HasOne(d => d.OpenSource)
                    .WithMany(p => p.UserInformations)
                    .HasForeignKey(d => d.OpenSourceId)
                    .HasConstraintName("userinformation_opensourceid_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserInformation)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userinformation_roleid_fkey");

                entity.HasOne(d => d.SubscriptionExecutor)
                    .WithMany(p => p.UserInformations)
                    .HasForeignKey(d => d.SubscriptionExecutorId)
                    .HasConstraintName("userinformation_subscriptionexecutorid_fkey");

                entity.HasOne(d => d.UserRegistration)
                    .WithMany(p => p.UserInformations)
                    .HasForeignKey(d => d.UserRegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userinformation_userregistrationid_fkey");
            });

            modelBuilder.Entity<UserPicture>(entity =>
            {
                entity.ToTable("userpicture");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasColumnName("ref");

                entity.Property(e => e.UserInformationId).HasColumnName("userinformationid");

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.UserPictures)
                    .HasForeignKey(d => d.UserInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userpicture_userinformationid_fkey");
            });

            modelBuilder.Entity<UserRegistration>(entity =>
            {
                entity.ToTable("userregistration");

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
                entity.ToTable("validationemail");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.EmailDescriptionId).HasColumnName("emaildescriptionid");

                entity.Property(e => e.ValidateCode)
                    .IsRequired()
                    .HasColumnName("validatecode");

                entity.HasOne(d => d.EmailDescription)
                    .WithMany(p => p.ValidationEmails)
                    .HasForeignKey(d => d.EmailDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("validationemail_emaildescriptionid_fkey");
            });

            modelBuilder.Entity<ValidationUser>(entity =>
            {
                entity.ToTable("validationuser");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.UserRegistrationId).HasColumnName("userregistrationid");

                entity.Property(e => e.ValidationCode)
                    .IsRequired()
                    .HasColumnName("validationcode");

                entity.HasOne(d => d.UserRegistration)
                    .WithMany(p => p.ValidationUsers)
                    .HasForeignKey(d => d.UserRegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("validationuser_userregistrationid_fkey");
            });
        }
        #endregion
    }
}
