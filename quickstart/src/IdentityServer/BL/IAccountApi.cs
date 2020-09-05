using IdentityServer.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.BL
{
    public interface IAccountApi
    {
        Task<IdentityResult> CreateNewAccount(RegistrationRequest model); 
    }
}
