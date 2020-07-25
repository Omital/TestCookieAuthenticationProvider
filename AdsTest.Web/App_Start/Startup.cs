﻿using System;
using Microsoft.AspNet.Identity.Owin;
using System.Configuration;
using Abp.Owin;
using AdsTest.Api.Controllers;
using AdsTest.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using AdsTest.Authorization.Users;

[assembly: OwinStartup(typeof(Startup))]

namespace AdsTest.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseAbp();

            app.UseOAuthBearerAuthentication(AccountController.OAuthBearerOptions);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                // evaluate for Persistent cookies (IsPermanent == true). Defaults to 14 days when not set.
                ExpireTimeSpan = new TimeSpan(int.Parse(ConfigurationManager.AppSettings["AuthSession.ExpireTimeInDays.WhenPersistent"] ?? "14"), 0, 0, 0),
                SlidingExpiration = bool.Parse(ConfigurationManager.AppSettings["AuthSession.SlidingExpirationEnabled"] ?? bool.FalseString),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<UserManager, User>(
                    validateInterval: TimeSpan.FromMinutes(15),
                    regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager)),
                },
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            app.MapSignalR();
        }
    }
}
