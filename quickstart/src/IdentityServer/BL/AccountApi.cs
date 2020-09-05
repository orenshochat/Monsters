using IdentityModel;
using IdentityServer.DAL.Models;
using IdentityServer.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.BL
{
    public class AccountApi : IAccountApi
    {
        private readonly UserManager<MonsterUser> _userManager;

        public AccountApi(UserManager<MonsterUser> userManager)
        {
            _userManager = userManager; 
        }
        public async Task<IdentityResult> CreateNewAccount(RegistrationRequest model)
        {
            var newUser = new MonsterUser
            {
                Id = model.UserName,
                UserName = model.UserName,
                EmailConfirmed = false
            };
            newUser.PasswordHash = new PasswordHasher<MonsterUser>().HashPassword(newUser, model.Password);

            var result = await _userManager.CreateAsync(newUser).ConfigureAwait(false);
            MonsterUser identityUser = await _userManager.FindByIdAsync(model.UserName).ConfigureAwait(false);



            var claims = new List<Claim>()
            {
                new Claim(JwtClaimTypes.GivenName, model.FirstName),
                new Claim(JwtClaimTypes.FamilyName, model.LastName),
                new Claim(CustomClaimTypes.TentclesClaim, model.Tentacles.ToString()),
                new Claim(CustomClaimTypes.StartedScaringClaim, DateTime.Today.Date.ToString("yyyy-MM-dd")),
                new Claim(JwtClaimTypes.PhoneNumber, model.Phone),
                new Claim(CustomClaimTypes.Username, model.UserName),
            };

            return await _userManager.AddClaimsAsync(identityUser, claims);
        }
    }
}
