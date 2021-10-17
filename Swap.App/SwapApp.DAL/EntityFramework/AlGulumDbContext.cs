using AlGulumVerGulum.DAL.EntityFramework.Mapping;
using AlGulumVerGulum.DAL.Extensions;
using AlGulumVerGulum.DOMAIN.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.DAL.EntityFramework
{
    public class AlGulumDbContext : DbContext
    {
        private readonly IConfiguration configuration;
        public AlGulumDbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Connection String appsettings.json içine taşınacak
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("cstrAlGulum"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new NoticeMap());
            builder.ApplyConfiguration(new PictureMap());
            builder.ApplyConfiguration(new SwapMap());

            SeedDataProvider.AddSeedData(builder);

            base.OnModelCreating(builder);
        }

        public DbSet<Swap> Swaps { get; set; }
        public DbSet<Envelope> Envelopes { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
    }
}
