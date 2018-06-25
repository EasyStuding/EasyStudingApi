using Microsoft.EntityFrameworkCore;
using EasyStudingModels.Models;

namespace EasyStudingRepositories.DbContext
{
    public partial class EasyStudingContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public const string CONNECTION_STRING = "Host=localhost;Port=5432;Database=EasyStuding;Username=postgres;Password=admin";

        public EasyStudingContext()
        {
        }

        public EasyStudingContext(DbContextOptions<EasyStudingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderSkill> OrderSkills { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSkill> UserSkills { get; set; }
        public virtual DbSet<UserPassword> UserPasswords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(CONNECTION_STRING);
            }
        }
    }
}
