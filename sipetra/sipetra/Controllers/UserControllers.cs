using sipetra.Helpers;
using sipetra.Models;
using System;

namespace sipetra.Controllers
{
    public class UserControllers
    {
        private UserContext context = new UserContext();

        public bool RegisterUser(UserModel user)  // ✅ UserModel (bukan UserModels)
        {
            if (string.IsNullOrWhiteSpace(user.Nama))
            {
                throw new Exception("Username tidak boleh kosong!");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new Exception("Password tidak boleh kosong!");
            }

            return user.Register();
        }

        public bool Login(UserModel user)  // ✅ UserModel (bukan UserModels)
        {
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new Exception("Email tidak boleh kosong!");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new Exception("Password tidak boleh kosong!");
            }

            return user.Login();
        }

        public bool CheckEmail(string email)
        {
            return context.IsEmailExists(email);
        }
    }
}