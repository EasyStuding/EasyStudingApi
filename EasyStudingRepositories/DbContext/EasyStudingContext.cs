﻿using Microsoft.EntityFrameworkCore;
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

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderSkill> OrderSkills { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skills");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.UserId)
                    .HasColumnName("Id");
            });
        }
    }
}
