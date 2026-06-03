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
                string query = "INSERT INTO users (nama, email, password, is_admin) VALUES (@Nama, @Email, @Password, @IsAdmin)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", user.nama);
                    cmd.Parameters.AddWithValue("@Email", user.email);
                    cmd.Parameters.AddWithValue("@Password", user.password);
                    cmd.Parameters.AddWithValue("@IsAdmin", user.isAdmin);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nama, email, password, is_admin FROM users WHERE LOWER(email) = LOWER(@Email) AND password = @Password";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email?.Trim() ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Password", password?.Trim() ?? string.Empty);

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
                            password = reader.GetString(reader.GetOrdinal("password")),
                            isAdmin = reader.GetBoolean(reader.GetOrdinal("is_admin"))
                        };
                    }
                }
            }
        }
    }
}
