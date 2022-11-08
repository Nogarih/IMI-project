using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserWatchItemSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserWatchItem>().HasData(
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new UserWatchItem
                {
                    WatchItemId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                }
                );
        }
    }
}