using IdentityModel;
using IdentityServer4.EntityFramework.Entities;
//using IdentityServer4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data
{
    public static class ConfigurationDbContextExtensions
    {
        public static void Seed(this ConfigurationDbContext dbcontext, ModelBuilder builder)
        {
            builder.Entity<ApiResource>()
            .HasData(
                new ApiResource
                {
                    Id = 1,
                    Name = "monsters_api",
                    DisplayName = "Monsters Web API",
                }
            );
            builder.Entity<ApiResourceScope>()
            .HasData(
                new ApiResourceScope
                {
                    Id = 1,
                    ApiResourceId = 1,
                    Scope = "monsters_api"
                }
            );


            builder.Entity<ApiScope>()
                .HasData(
                    new ApiScope
                    {
                        Id = 1,
                        Name = "monsters_api",
                        DisplayName = "Monsters Web API",
                        Description = "Allows scaring children behind doors",
                        Required = false,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,

                    }
                );

            builder.Entity<IdentityResource>().HasData
                (
                    new IdentityResource()
                    {
                        Id = 1,
                        Enabled = true,
                        Name = CustomResourceTypes.OpenId,
                        DisplayName = "Your user identifier",
                        Description = null,
                        Required = true,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    },
                    new IdentityResource()
                    {
                        Id = 2,
                        Enabled = true,
                        Name = CustomResourceTypes.Profile,
                        DisplayName = "User profile",
                        Description = "Your user profile information (tentacles, started scaring, etc.)",
                        Required = false,
                        Emphasize = true,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    });

            builder.Entity<ApiResourceClaim>()
                .HasData(
                new ApiResourceClaim
                {
                    Id = 1,
                    ApiResourceId = 1,
                    Type = JwtClaimTypes.Subject
                },
                new ApiResourceClaim
                {
                    Id = 2,
                    ApiResourceId = 1,
                    Type = CustomClaimTypes.TentclesClaim
                },
                new ApiResourceClaim
                {
                    Id = 3,
                    ApiResourceId = 1,
                    Type = CustomClaimTypes.StartedScaringClaim
                },
                new ApiResourceClaim
                {
                    Id = 4,
                    ApiResourceId = 1,
                    Type = JwtClaimTypes.GivenName,
                },
                new ApiResourceClaim
                {
                    Id = 5,
                    ApiResourceId = 1,
                    Type = JwtClaimTypes.FamilyName,
                },
                new ApiResourceClaim
                {
                    Id = 6,
                    ApiResourceId = 1,
                    Type = JwtClaimTypes.Name,
                },
                new ApiResourceClaim
                {
                    Id = 7,
                    ApiResourceId = 1,
                    Type = JwtClaimTypes.PhoneNumber,
                },
                new ApiResourceClaim
                {
                    Id = 8,
                    ApiResourceId = 1,
                    Type = CustomClaimTypes.Username,
                }


            );

            builder.Entity<IdentityResourceClaim>()
                .HasData(
                    new IdentityResourceClaim
                    {
                        Id = 1,
                        IdentityResourceId = 1,
                        Type = JwtClaimTypes.Subject,//"sub"
                    },
                    new IdentityResourceClaim
                    {
                        Id = 2,
                        IdentityResourceId = 2,
                        Type = CustomClaimTypes.TentclesClaim
                    },
                    new IdentityResourceClaim
                    {
                        Id = 3,
                        IdentityResourceId = 2,
                        Type = CustomClaimTypes.StartedScaringClaim
                    },
                    new IdentityResourceClaim
                    {
                        Id = 4,
                        IdentityResourceId = 2,
                        Type = JwtClaimTypes.GivenName,
                    },
                    new IdentityResourceClaim
                    {
                        Id = 5,
                        IdentityResourceId = 2,
                        Type = JwtClaimTypes.FamilyName
                    },
                    new IdentityResourceClaim
                    {
                        Id = 6,
                        IdentityResourceId = 2,
                        Type = JwtClaimTypes.Name
                    },
                    new IdentityResourceClaim
                    {
                        Id = 7,
                        IdentityResourceId = 2,
                        Type = JwtClaimTypes.PhoneNumber,
                    },
                    new IdentityResourceClaim
                    {
                        Id = 8,
                        IdentityResourceId = 2,
                        Type = CustomClaimTypes.Username,
                    }
                    );

            builder.Entity<Client>()
                    .HasData(
                        new Client
                        {
                            Id = 1,
                            Enabled = true,
                            ClientId = "client",
                            ProtocolType = "oidc",
                            RequireClientSecret = true,
                            RequireConsent = true,
                            ClientName = null,
                            Description = null,
                            AllowRememberConsent = true,
                            AlwaysIncludeUserClaimsInIdToken = false,
                            RequirePkce = false,
                            AllowAccessTokensViaBrowser = false,
                            AllowOfflineAccess = false,
                        },
                        new Client
                        {
                            Id = 2,
                            Enabled = true,
                            ClientId = "ro.client",
                            ProtocolType = "oidc",
                            RequireClientSecret = true,
                            RequireConsent = true,
                            ClientName = null,
                            Description = null,
                            AllowRememberConsent = true,
                            AlwaysIncludeUserClaimsInIdToken = false,
                            RequirePkce = false,
                            AllowAccessTokensViaBrowser = false,
                            AllowOfflineAccess = false
                        },
                        new Client
                        {
                            Id = 3,
                            Enabled = true,
                            ClientId = "monsterdemo",
                            ProtocolType = "oidc",
                            RequireClientSecret = true,
                            RequireConsent = false,
                            ClientName = "Monster Client Demo",
                            Description = "Demo app to test the monster api and the identity server.",
                            AllowRememberConsent = true,
                            AlwaysIncludeUserClaimsInIdToken = true,
                            RequirePkce = false,
                            AllowAccessTokensViaBrowser = false,
                            AllowOfflineAccess = true,
                            
                        },
                        new Client
                        {
                            Id = 4,
                            Enabled = true,
                            ClientId = "js",
                            ProtocolType = "oidc",
                            RequireClientSecret = true,
                            RequireConsent = true,
                            ClientName = "JavaScript client",
                            Description = null,
                            AllowRememberConsent = true,
                            AlwaysIncludeUserClaimsInIdToken = false,
                            RequirePkce = true,
                            AllowAccessTokensViaBrowser = false,
                            AllowOfflineAccess = false,
                        });  ;

            builder.Entity<ClientGrantType>()
                    .HasData(
                        new ClientGrantType
                        {
                            Id = 1,
                            GrantType = IdentityServer4.Models.GrantType.ClientCredentials,
                            ClientId = 1
                        },
                        new ClientGrantType
                        {
                            Id = 2,
                            GrantType = IdentityServer4.Models.GrantType.ResourceOwnerPassword,
                            ClientId = 2
                        },
                        new ClientGrantType
                        {
                            Id = 3,
                            GrantType = IdentityServer4.Models.GrantType.Hybrid,
                            ClientId = 3
                        },
                        new ClientGrantType
                        {
                            Id = 4,
                            GrantType = IdentityServer4.Models.GrantType.AuthorizationCode,
                            ClientId = 4
                        });

            builder.Entity<ClientScope>()
                .HasData(
                    new ClientScope
                    {
                        Id = 1,
                        Scope = CustomResourceTypes.Profile,
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 2,
                        Scope = CustomResourceTypes.Profile,
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 3,
                        Scope = "openid",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 4,
                        Scope = "openid",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 5,
                        Scope = "monsters_api",
                        ClientId = 1
                    }
                    ,
                    new ClientScope
                    {
                        Id = 6,
                        Scope = "monsters_api",
                        ClientId = 2
                    }
                    ,
                    new ClientScope
                    {
                        Id = 7,
                        Scope = "monsters_api",
                        ClientId = 3
                    }
                    ,
                    new ClientScope
                    {
                        Id = 8,
                        Scope = "monsters_api",
                        ClientId = 4
                    });

            builder.Entity<ClientSecret>()
                .HasData(
                        new ClientSecret
                        {
                            Id = 1,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 1
                        },
                        new ClientSecret
                        {
                            Id = 2,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 2
                        },
                        new ClientSecret
                        {
                            Id = 3,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 3
                        });

            builder.Entity<ClientPostLogoutRedirectUri>()
                .HasData(
                new ClientPostLogoutRedirectUri
                {
                    Id = 1,
                    PostLogoutRedirectUri = "https://localhost:44310/signout-callback-oidc",
                    ClientId = 3
                },
                new ClientPostLogoutRedirectUri
                {
                    Id = 2,
                    PostLogoutRedirectUri = "http://localhost:50339/index.html",
                    ClientId = 4
                });

            builder.Entity<ClientRedirectUri>()
                .HasData(
                new ClientRedirectUri
                {
                    Id = 1,
                    RedirectUri = "https://localhost:44310/signin-oidc",
                    ClientId = 3
                },
                new ClientRedirectUri
                {
                    Id = 2,
                    RedirectUri = "http://localhost:5003/callback.html",
                    ClientId = 4
                });

            builder.Entity<ClientCorsOrigin>()
                .HasData(
                new ClientCorsOrigin
                {
                    Id = 1,
                    Origin = "http://localhost:5003",
                    ClientId = 4
                });

        }
    }
}
