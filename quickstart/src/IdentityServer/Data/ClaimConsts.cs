using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data
{
    public static class CustomResourceTypes
    {
        public const string OpenId = "openid";
        public const string Profile = "profile";
        public const string MonsterProfile = "monster_profile";
    }
    public static class CustomClaimTypes
    {
        public const string TentclesClaim = "tentacles";
        public const string StartedScaringClaim = "started_scaring";
        public const string GivenNameClaim = "given_name";
        public const string FamilyNameClaim = "family_name";
        public const string PhoneNumberClaim = "phone_number";
        public const string Username = "user_name";

    }
}
