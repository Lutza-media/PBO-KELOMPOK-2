using Npgsql;

namespace sipetra.Helpers
{
    public class DatabaseHelper
    {
        // GANTI dengan koneksi database Anda
        private static string connString = "Host=localhost;Port=5432;Database=sipetra;Username=postgres;Password=110606";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}