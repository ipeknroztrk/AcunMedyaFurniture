using System;
using AcunMedyaFurniter.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaFurniter.DAL.Context
{
	public class FurnitureContext:IdentityDbContext<AppUser,AppRole,int>
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=AcunMedyaFurniterDb;User Id=postgres;Password=12345678;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}

  



