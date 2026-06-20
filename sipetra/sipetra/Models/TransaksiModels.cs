using System;
using System.Collections.Generic;
using System.Globalization;
using Npgsql;
using sipetra.Helpers;

namespace sipetra.Models
{
    public class TransaksiModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public string JenisTiket { get; set; }
        public int Jumlah { get; set; }
        public int TotalHarga { get; set; }
        public string Status { get; set; }

        public TransaksiModel() { }

        public TransaksiModel(int userId, string jenisTiket, int jumlah, int totalHarga)
        {
            UserId = userId;
            JenisTiket = jenisTiket;
            Jumlah = jumlah;
            TotalHarga = totalHarga;
            TanggalTransaksi = DateTime.Now; // Gunakan DateTime.Now langsung
            Status = "Lunas";
        }

        public bool Save()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO transaksi 
                                    (user_id, tanggal_transaksi, jenis_tiket, jumlah, total_harga, status) 
                                    VALUES (@user_id, @tanggal, @jenis_tiket, @jumlah, @total_harga, @status)
                                    RETURNING id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", UserId);
                        // PASTIKAN FORMAT TANGGAL BENAR
                        cmd.Parameters.AddWithValue("@tanggal", TanggalTransaksi);
                        cmd.Parameters.AddWithValue("@jenis_tiket", JenisTiket);
                        cmd.Parameters.AddWithValue("@jumlah", Jumlah);
                        cmd.Parameters.AddWithValue("@total_harga", TotalHarga);
                        cmd.Parameters.AddWithValue("@status", Status);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            Id = Convert.ToInt32(result);
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving transaction: {ex.Message}");
                return false;
            }
        }

        public static List<TransaksiModel> GetByUserId(int userId)
        {
            List<TransaksiModel> list = new List<TransaksiModel>();
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM transaksi 
                                    WHERE user_id = @user_id 
                                    ORDER BY tanggal_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new TransaksiModel
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    // PERBAIKI FORMAT TANGGAL DI SINI
                                    TanggalTransaksi = Convert.ToDateTime(reader["tanggal_transaksi"]),
                                    JenisTiket = reader["jenis_tiket"].ToString(),
                                    Jumlah = Convert.ToInt32(reader["jumlah"]),
                                    TotalHarga = Convert.ToInt32(reader["total_harga"]),
                                    Status = reader["status"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading transactions: {ex.Message}");
                throw;
            }
            return list;
        }

        // ===========================================================
        // KHUSUS ADMIN: ambil semua transaksi dari semua customer, lengkap dengan nama & email pemesan
        // ===========================================================
        public static List<TransaksiModelAdminView> GetAllForAdmin()
        {
            var list = new List<TransaksiModelAdminView>();
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT t.id, t.user_id, u.nama, u.email, t.tanggal_transaksi,
                                             t.jenis_tiket, t.jumlah, t.total_harga, t.status
                                      FROM transaksi t
                                      JOIN users u ON u.id = t.user_id
                                      ORDER BY t.tanggal_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TransaksiModelAdminView
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                NamaCustomer = reader["nama"].ToString(),
                                EmailCustomer = reader["email"].ToString(),
                                TanggalTransaksi = Convert.ToDateTime(reader["tanggal_transaksi"]),
                                JenisTiket = reader["jenis_tiket"].ToString(),
                                Jumlah = Convert.ToInt32(reader["jumlah"]),
                                TotalHarga = Convert.ToInt32(reader["total_harga"]),
                                Status = reader["status"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading admin transactions: {ex.Message}");
                throw;
            }
            return list;
        }

        // Total pendapatan dari semua transaksi (khusus admin, untuk statistik dashboard)
        public static int GetTotalPendapatan()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COALESCE(SUM(total_harga), 0) FROM transaksi";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Total jumlah transaksi (khusus admin, untuk statistik dashboard)
        public static int CountAllTransaksi()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM transaksi";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // METHOD UNTUK FORMAT TANGGAL YANG AMAN
        public string GetFormattedDate()
        {
            // Format: 19/06/2026 11:43
            return TanggalTransaksi.ToString("dd/MM/yyyy HH:mm");
        }

        public string GetFormattedDateISO()
        {
            // Format: 2026-06-19 11:43:00
            return TanggalTransaksi.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

    // ===========================================================
    // KHUSUS ADMIN: representasi transaksi + identitas customer pemesan (hasil JOIN)
    // ===========================================================
    public class TransaksiModelAdminView
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string NamaCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public string JenisTiket { get; set; }
        public int Jumlah { get; set; }
        public int TotalHarga { get; set; }
        public string Status { get; set; }
    }
}