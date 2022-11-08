
using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Roles
            string AdminRoleId = "00000000-0000-0000-0000-000000000001"; 
            string AdminRoleName = MyUserRoles.Admin;

            string UserRoleId = "00000000-0000-0000-0000-000000000002";
            string UserRoleName = MyUserRoles.User;


            // Admins
            string AdminUserId = "00000000-0000-0000-0000-000000000001";
            const string AdminUserName = "PriAdmin";
            const string AdminEmail = "admin@pri.be";

            // Users
            string PriUserId = "00000000-0000-0000-0000-000000000002";
            string PriUserUserName = "PriUser";
            string PriUserEmail = "user@pri.be";

            string PriRefuserId = "00000000-0000-0000-0000-000000000003";
            string PriRefuserUserName = "PriRefuser";
            string PriRefuserEmail = "refuser@pri.be";


            const string seedingPassword = "Test123?"; // For demo purposes only! Don't do this in real application!


            IPasswordHasher<User> passwordHasher = new PasswordHasher<User>(); // Identity password hasher

            var usersToSeed = new List<User>();


            User adminUser = new User
            {
                Id = AdminUserId,
                UserName = AdminUserName,
                NormalizedUserName = AdminUserName.ToUpper(),
                Email = AdminEmail,
                NormalizedEmail = AdminEmail.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", //Random string
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58", //Random guid string
                Birthday = new DateTime(1996, 02, 15)
            };

            usersToSeed.Add(adminUser);



            User priUser = new User
            {
                Id = PriUserId,
                UserName = PriUserUserName,
                NormalizedUserName = PriUserUserName.ToUpper(),
                Email = PriUserEmail,
                NormalizedEmail = PriUserEmail.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINB", //Random string
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc59", //Random guid string
                Birthday = new DateTime(1990, 04, 02),
                HasApprovedTermsAndConditions= true
            };

            usersToSeed.Add(priUser);

            User priRefuser = new User
            {
                Id = PriRefuserId,
                UserName = PriRefuserUserName,
                NormalizedUserName = PriRefuserUserName.ToUpper(),
                Email = PriRefuserEmail,
                NormalizedEmail = PriRefuserEmail.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINC", //Random string
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc60", //Random guid string
                Birthday = new DateTime(1986, 02, 18),
                HasApprovedTermsAndConditions = false
            };

            usersToSeed.Add(priRefuser);

            usersToSeed.Add(
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000004",
                    UserName = "emeuleni",
                    NormalizedUserName = "EMEULENI",
                    Email = "ellen@email.com",
                    NormalizedEmail = "ELLEN@EMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINC", //Random string
                    ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc60", //Random guid string
                    Birthday = new DateTime(1996, 02, 15),
                    HasApprovedTermsAndConditions = true
                });

            usersToSeed.Add(
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000005",
                    UserName = "jordanh",
                    NormalizedUserName = "JORDANH",
                    Email = "jordanh@email.com",
                    NormalizedEmail = "JORDANH@EMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINC", //Random string
                    ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc60", //Random guid string
                    Birthday = new DateTime(1995, 05, 28),
                    HasApprovedTermsAndConditions = false
                });


            foreach (var user in usersToSeed)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, seedingPassword);
            }

            modelBuilder.Entity<User>().HasData(usersToSeed);

            modelBuilder.Entity <IdentityRole>().HasData(new IdentityRole
            {
                Id = AdminRoleId,
                Name = AdminRoleName,
                NormalizedName = AdminRoleName.ToUpper()
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = UserRoleId,
                Name = UserRoleName,
                NormalizedName = UserRoleName.ToUpper()
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdminRoleId,
                    UserId = AdminUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = UserRoleId,
                    UserId = PriUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = UserRoleId,
                    UserId = PriRefuserId
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = UserRoleId,
                    UserId = "00000000-0000-0000-0000-000000000004"
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = UserRoleId,
                    UserId = "00000000-0000-0000-0000-000000000005"
                }
            );

            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = AdminUserId,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = MyUserRoles.Admin
                },
                new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = PriUserId,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = MyUserRoles.User
                },
                new IdentityUserClaim<string>
                {
                    Id = 3,
                    UserId = PriUserId,
                    ClaimType = MyClaimTypes.HasApprovedTermsClaimType,
                    ClaimValue = "True"
                },
                new IdentityUserClaim<string>
                {
                    Id = 4,
                    UserId = PriRefuserId,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = MyUserRoles.User
                },
                new IdentityUserClaim<string>
                {
                    Id = 5,
                    UserId = PriRefuserId,
                    ClaimType = MyClaimTypes.HasApprovedTermsClaimType,
                    ClaimValue = "False"
                },
                new IdentityUserClaim<string>
                {
                    Id = 6,
                    UserId = "00000000-0000-0000-0000-000000000004",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = MyUserRoles.User
                },
                new IdentityUserClaim<string>
                {
                    Id = 7,
                    UserId = "00000000-0000-0000-0000-000000000004",
                    ClaimType = MyClaimTypes.HasApprovedTermsClaimType,
                    ClaimValue = "True"
                },
                new IdentityUserClaim<string>
                {
                    Id = 8,
                    UserId = "00000000-0000-0000-0000-000000000005",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = MyUserRoles.User
                },
                new IdentityUserClaim<string>
                {
                    Id = 9,
                    UserId = "00000000-0000-0000-0000-000000000005",
                    ClaimType = MyClaimTypes.HasApprovedTermsClaimType,
                    ClaimValue = "False"
                }
                );
        }
    }
}