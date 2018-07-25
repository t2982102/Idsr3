using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idsr3.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
        {
            new Client
            {
                ClientName = "MVC Client",
                ClientId = "mvc",
                Flow = Flows.Implicit,

                RedirectUris = new List<string>
                {
                    "http://localhost:5000/"
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "http://localhost:5000/"
                },
                AllowedScopes = new List<string>
                {
                    "openid",
                    "profile",
                    "roles",
                    "sampleApi"
                }
            },
            new Client
            {
                ClientName = "WebApi Client",
                ClientId = "webapiclient",
                Flow = Flows.Implicit,

                RedirectUris = new List<string>
                {
                    "http://localhost:5001/"
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "http://localhost:5001/"
                },
                //AllowedScopes = new List<string>
                //{
                //    "openid",
                //    "profile",
                //    "roles",
                //    "sampleApi"
                //}
                AllowAccessToAllScopes = true
            },
            new Client
            {
                ClientName = "MVC Client (service communication)",
                ClientId = "mvc_service",
                Flow = Flows.ClientCredentials,
                
                ClientSecrets = new List<Secret>
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = new List<string>
                {
                    "sampleApi"
                }
            }
        };
        }
    }
}