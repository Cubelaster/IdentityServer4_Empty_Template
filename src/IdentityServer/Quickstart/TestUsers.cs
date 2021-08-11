// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Test;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                var address = new
                {
                    street_address = "One Hacker Way",
                    locality = "Heidelberg",
                    postal_code = 69118,
                    country = "USA"
                };

                var custom_claims = new
                {
                    full_name = "Full Cubelaster",
                    dummy = "Dummy Cubelaster"
                };

                var custom_profile = new
                {
                    status = "New"
                };

                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "818727",
                        Username = "Cubelaster",
                        Password = "Cubelaster",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Cubelaster"),
                            new Claim("Kita", "kita"),
                            new Claim(JwtClaimTypes.GivenName, "Cubelaster"),
                            new Claim(JwtClaimTypes.FamilyName, "Cubelaster"),
                            new Claim(JwtClaimTypes.Email, "Cubelaster@cubelaster.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "https://github.com/Cubelaster"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json),
                            new Claim("custom_claims", JsonSerializer.Serialize(custom_claims), IdentityServerConstants.ClaimValueTypes.Json),
                            new Claim("custom.profile", JsonSerializer.Serialize(custom_profile), IdentityServerConstants.ClaimValueTypes.Json),
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "88421113",
                        Username = "bob",
                        Password = "bob",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Bob Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Bob"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json),
                            new Claim("custom_claims", JsonSerializer.Serialize(custom_claims), IdentityServerConstants.ClaimValueTypes.Json),
                            new Claim("custom.profile", JsonSerializer.Serialize(custom_profile), IdentityServerConstants.ClaimValueTypes.Json),

                        }
                    }
                };
            }
        }
    }
}