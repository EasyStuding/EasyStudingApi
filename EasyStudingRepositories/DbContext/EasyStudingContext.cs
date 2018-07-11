using Microsoft.EntityFrameworkCore;
using EasyStudingModels.Models;
using EasyStudingModels;

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
                optionsBuilder.UseNpgsql(AppSettings.DBConnectionString);
            }
        }
    }
}
