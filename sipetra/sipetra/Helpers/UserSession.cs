using System;
using System.Collections.Generic;
using System.Text;
using sipetra.Models;

namespace sipetra.Helpers
{
    public sealed class UserSession
    {
        private static readonly Lazy<UserSession> lazy =
            new Lazy<UserSession>(() => new UserSession());

        public static UserSession Instance { get { return lazy.Value; } }

        public UserModel CurrentUser { get; private set; }  // ✅ UserModel

        private UserSession() { }

        public void SetUser(UserModel user)  // ✅ UserModel
        {
            CurrentUser = user;
        }

        public void ClearSession()
        {
            CurrentUser = null;
        }

        public bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}