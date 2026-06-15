// ===========================================================
// OOP PILAR 1 - ENCAPSULATION: semua field private, akses via property dengan validasi
// OOP PILAR 3 - INHERITANCE: class ini jadi base class untuk AdminUser
// OOP PILAR 4 - POLYMORPHISM: method virtual GetRole(), GetHakAkses(), GetInfoAkun()
// ===========================================================
using System;
using Npgsql;
using sipetra.Helpers;

namespace sipetra.Models
{
    public class User
    {
        // ENCAPSULATION: field private
        private int id;
        private string nama;
        private string email;
        private string password;
        private bool isAdmin;

        // Properties dengan validasi
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nama
        {
            get { return nama; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nama tidak boleh kosong.");
                nama = value.Trim();
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Email tidak boleh kosong.");
                if (!value.Contains("@"))
                    throw new Exception("Format email tidak valid.");
                email = value.Trim();
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Password tidak boleh kosong.");
                if (value.Length < 6)
                    throw new Exception("Password minimal 6 karakter.");
                password = value;
            }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        // Constructor kosong
        public User() { }

        // Constructor berparameter
        public User(string nama, string email, string password)
        {
            Nama = nama;
            Email = email;
            Password = password;
        }

        // POLYMORPHISM: virtual method, di-override di AdminUser
        public virtual string GetRole()
        {
            return "User";
        }

        public virtual string GetHakAkses()
        {
            return "Dapat memesan tiket dan melihat riwayat transaksi.";
        }

        public virtual string GetInfoAkun()
        {
            return $"Nama  : {Nama}\nEmail : {Email}\nRole  : {GetRole()}";
        }

        // Method Register ke database
        public bool Register()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM users WHERE email=@email";
                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@email", Email);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0) throw new Exception("Email sudah terdaftar.");
                }
                string query = "INSERT INTO users (nama, email, katasandi, is_admin) VALUES (@nama, @email, @password, false)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", Nama);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Method Login
        public bool Login()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE email=@email AND katasandi=@password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }



        // Ambil data lengkap user setelah login (termasuk Id)
        public bool LoadUserData()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email=@email";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", Email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            Nama = reader["nama"].ToString();
                            IsAdmin = Convert.ToBoolean(reader["is_admin"]);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        // Update nama dan email profil
        public bool UpdateProfil(string namaBaru, string emailBaru)
        {
            if (string.IsNullOrWhiteSpace(namaBaru))
                throw new Exception("Nama tidak boleh kosong.");
            if (string.IsNullOrWhiteSpace(emailBaru) || !emailBaru.Contains("@"))
                throw new Exception("Format email tidak valid.");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Cek email tidak dipakai user lain
                if (emailBaru.Trim() != Email)
                {
                    string cek = "SELECT COUNT(*) FROM users WHERE email=@email AND id != @id";
                    using (var cekCmd = new NpgsqlCommand(cek, conn))
                    {
                        cekCmd.Parameters.AddWithValue("@email", emailBaru.Trim());
                        cekCmd.Parameters.AddWithValue("@id", Id);
                        if (Convert.ToInt32(cekCmd.ExecuteScalar()) > 0)
                            throw new Exception("Email sudah digunakan akun lain.");
                    }
                }
                string query = "UPDATE users SET nama=@nama, email=@email WHERE id=@id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", namaBaru.Trim());
                    cmd.Parameters.AddWithValue("@email", emailBaru.Trim());
                    cmd.Parameters.AddWithValue("@id", Id);
                    bool ok = cmd.ExecuteNonQuery() > 0;
                    if (ok) { Nama = namaBaru.Trim(); Email = emailBaru.Trim(); }
                    return ok;
                }
            }
        }
    }
}