using System;
using System.Collections.Generic;
using System.Text;

namespace sipetra.Models
{
    public class User
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string katasandi { get; set; }
        public bool isAdmin { get; set; }

        //public User(int id, string nama, string email, string katasandi, bool isAdmin)
        //{
        //    this.id = id;
        //    this.nama = nama;
        //    this.email = email;
        //    this.password = password;
        //    this.isAdmin = isAdmin;
        //}
    }
}
