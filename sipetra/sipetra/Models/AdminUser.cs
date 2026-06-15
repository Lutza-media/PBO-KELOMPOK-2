// ===========================================================
// OOP PILAR 3 - INHERITANCE: AdminUser mewarisi semua dari User
// OOP PILAR 4 - POLYMORPHISM: override GetRole, GetHakAkses, GetInfoAkun
// ===========================================================
using System;

namespace sipetra.Models
{
    public class AdminUser : User
    {
        // Constructor kosong
        public AdminUser() : base()
        {
            IsAdmin = true;
        }

        // Constructor berparameter
        public AdminUser(string nama, string email, string password)
            : base(nama, email, password)
        {
            IsAdmin = true;
        }

        // POLYMORPHISM: override method dari base class User
        public override string GetRole()
        {
            return "Admin";
        }

        public override string GetHakAkses()
        {
            return "Dapat mengelola semua data tiket, transaksi, dan pengguna.";
        }

        public override string GetInfoAkun()
        {
            return $"[ADMIN]\nNama  : {Nama}\nEmail : {Email}\nRole  : {GetRole()}\nHak   : {GetHakAkses()}";
        }
    }
}