using System;
using System.Collections.Generic;
using System.Text;
using sipetra.Models;

namespace sipetra.Helpers
{
    public class UserContext
    {
        public void AddUser(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO users (nama, email, katasandi, is_admin) VALUES (@Nama, @Email, @Katasandi, @IsAdmin)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", user.Nama);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Katasandi", user.Password);
                    cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetUserByEmailAndPassword(string email, string katasandi)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nama, email, katasandi, is_admin FROM users WHERE LOWER(email) = LOWER(@Email) AND katasandi = @Katasandi";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email?.Trim() ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Katasandi", katasandi?.Trim() ?? string.Empty);


                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return new User
                        {
                            Nama = reader.GetString(reader.GetOrdinal("nama")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            Password = reader.GetString(reader.GetOrdinal("katasandi")),
                        };
                    }
                }
            }
        }

        public bool IsEmailExists(string email)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE LOWER(email) = LOWER(@Email)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email?.Trim() ?? string.Empty);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


    }

}
