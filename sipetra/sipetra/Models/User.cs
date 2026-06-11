using System;
using System.Collections.Generic;
using System.Text;
using System;
using Npgsql;

namespace sipetra.Models
{
    public class User
    {
        // Encapsulation: field private
        private string username;
        private string email;
        private string password;
        private bool isAdmin;

        // Property untuk mengakses field private
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Email
        {
            get { return Email; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            private set { isAdmin = value; }
        }

        // Connection string disembunyikan dari class lain
        private readonly string connectionString =
        "Host=localhost;Port=5432;Database=sipetra;Username=postgres;Password=110606";

        // Constructor kosong
        public User()
        {
        }

        // Constructor dengan parameter
        public User(string username, string  email, string password, bool isAdmin)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;

        }

        // Method Register
        public bool Register()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO users(username, email, password) VALUES(@username, @email, @password)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", Password);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Register: " + ex.Message);
                return false;
            }
        }

        // Method Login
        public bool Login()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@password", Password);
                        cmd.Parameters.AddWithValue("@isAdmin", false);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Login: " + ex.Message);
                return false;
            }
        }
    }
}