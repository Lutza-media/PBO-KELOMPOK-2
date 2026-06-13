using System;
using Npgsql;
using sipetra.Helpers;

namespace sipetra.Models
{
    public class User
    {
        // Encapsulated Fields
        private int id;
        private string nama;
        private string email;
        private string password;
        private bool isAdmin;

        // Properties
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

        // Constructor Kosong
        public User()
        {

        }

        // Constructor Berparameter
        public User(string nama, string email, string password)
        {
            Nama = nama;
            Email = email;
            Password = password;
        }

        // Polymorphism
        public virtual string GetRole()
        {
            return "User";
        }

        public virtual string GetHakAkses()
        {
            return "Hak akses umum";
        }

        // Method Register
        public bool Register()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string checkQuery =
                    "SELECT COUNT(*) FROM users WHERE email=@email";

                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@email", Email);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                        throw new Exception("Email sudah terdaftar.");
                }

                string query = @"
                    INSERT INTO users
                    (nama, email, katasandi, is_admin)
                    VALUES
                    (@nama, @email, @password, false)";

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

                string query = @"
                    SELECT COUNT(*)
                    FROM users
                    WHERE email=@email
                    AND katasandi=@password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        // Mengambil Data User Setelah Login
        public bool LoadUserData()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT *
                    FROM users
                    WHERE email=@email";

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
    }




}