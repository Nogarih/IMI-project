using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<WatchItem> WatchItems { get; set; }
        public DbSet<UserWatchItem> UserWatchItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Anime>().HasBaseType<WatchItem>();
            modelBuilder.Entity<Movie>().HasBaseType<WatchItem>();
            modelBuilder.Entity<TvSerie>().HasBaseType<WatchItem>();

            modelBuilder.Entity<UserWatchItem>()
                .HasKey(uw => new { uw.UserId, uw.WatchItemId });


            // Seeding
            DirectorSeeder.Seed(modelBuilder);
            LanguageSeeder.Seed(modelBuilder);
            GenreSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);
            WatchItemSeeder.Seed(modelBuilder);
            UserWatchItemSeeder.Seed(modelBuilder);
        }
    }
}