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
                    cmd.Parameters.AddWithValue("@Nama", user.nama);
                    cmd.Parameters.AddWithValue("@Email", user.email);
                    cmd.Parameters.AddWithValue("@Katasandi", user.katasandi);
                    cmd.Parameters.AddWithValue("@IsAdmin", user.isAdmin);
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
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nama = reader.GetString(reader.GetOrdinal("nama")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            katasandi = reader.GetString(reader.GetOrdinal("katasandi")),
                            isAdmin = reader.GetBoolean(reader.GetOrdinal("is_admin"))
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
