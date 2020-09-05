using IdentityModel;
using IdentityServer.DAL.Models;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data
{
    public static class IdentityDbContextExtensions
    {
        public static void Seed(this IdentityDbContext dbcontext, ModelBuilder builder)
        {
            var password = "A123456!";

            var james = new MonsterUser
            {
                Id = "1",
                UserName = "james",
                NormalizedUserName = "JAMES",
                PhoneNumber = "09-102023993",
                EmailConfirmed = false
            };

            james.PasswordHash = new PasswordHasher<MonsterUser>().HashPassword(james, password);

            //Michael "Mike" Wazowski

            var mike = new MonsterUser
            {
                Id = "2",
                UserName = "mike",
                NormalizedUserName = "MIKE",
                EmailConfirmed = false
            };

            mike.PasswordHash = new PasswordHasher<MonsterUser>().HashPassword(mike, password);


            builder.Entity<MonsterUser>()
                .HasData(james, mike);


            builder.Entity<IdentityUserClaim<string>>()
                .HasData(
                    new IdentityUserClaim<string>
                    {
                        Id = 1,
                        UserId = "1",
                        ClaimType = "name",
                        ClaimValue = "James Sullivan"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 2,
                        UserId = "1",
                        ClaimType = JwtClaimTypes.GivenName,
                        ClaimValue = "James"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 3,
                        UserId = "1",
                        ClaimType = JwtClaimTypes.FamilyName,
                        ClaimValue = "Sullivan"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 4,
                        UserId = "1",
                        ClaimType = CustomClaimTypes.TentclesClaim,
                        ClaimValue = "11"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 5,
                        UserId = "1",
                        ClaimType = CustomClaimTypes.StartedScaringClaim,
                        ClaimValue = "1990-10-22"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 6,
                        UserId = "1",
                        ClaimType = JwtClaimTypes.PhoneNumber,
                        ClaimValue = "0543300922"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 7,
                        UserId = "2",
                        ClaimType = "name",
                        ClaimValue = "Mike Wazowski"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 8,
                        UserId = "2",
                        ClaimType = JwtClaimTypes.GivenName,
                        ClaimValue = "Mike"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 9,
                        UserId = "2",
                        ClaimType = JwtClaimTypes.FamilyName,
                        ClaimValue = "Wazowski"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 10,
                        UserId = "2",
                        ClaimType = CustomClaimTypes.TentclesClaim,
                        ClaimValue = "2"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 11,
                        UserId = "2",
                        ClaimType = CustomClaimTypes.StartedScaringClaim,
                        ClaimValue = "2019-10-22"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 12,
                        UserId = "1",
                        ClaimType = "location",
                        ClaimValue = "somewhere"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 13,
                        UserId = "2",
                        ClaimType = "location",
                        ClaimValue = "somewhere else"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 14,
                        UserId = "1",
                        ClaimType = CustomClaimTypes.Username,
                        ClaimValue = "james"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 15,
                        UserId = "2",
                        ClaimType = CustomClaimTypes.Username,
                        ClaimValue = "mike"
                    });
        }

    }
}

