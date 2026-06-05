using System;
using System.Collections.Generic;
using System.Text;
using sipetra.Helpers;
using sipetra.Models;

namespace sipetra.Controllers
{
    public class UserControllers
    {
        private UserContext context = new UserContext();

        public void RegisterUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.nama))
            {
                throw new Exception("Nama gak boleh kosong!");
            }

            if (string.IsNullOrWhiteSpace(user.email))
            {
                throw new Exception("Email tidak boleh kosong!");
            }

            if (string.IsNullOrWhiteSpace(user.katasandi))
            {
                throw new Exception("Katasandi tidak boleh kosong!");
            }

            context.AddUser(user);
        }

        public User Login(User user)
        {
            if (string.IsNullOrWhiteSpace(user.email))
            {
                throw new Exception("Email tidak boleh kosong!");
            }

            if (string.IsNullOrWhiteSpace(user.katasandi))
            {
                throw new Exception("Katasandi tidak boleh kosong!");
            }

            return context.GetUserByEmailAndPassword(user.email, user.katasandi);
        }
    }
}
