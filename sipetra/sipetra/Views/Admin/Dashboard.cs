using Npgsql;
using sipetra.Helpers;
using sipetra.Models;  
using sipetra.Views.Shared;
using sipetra.Views.User;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace sipetra.Views.Admin
{
    public partial class Dashboard : Form
    {
        private UserModel? _currentUser;  // ✅ UserModel (bukan Models.UserModels)
        private DataTable _dataTableTiket;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(UserModel user) : this()  // ✅ UserModel (bukan Models.UserModels)
        {
            _currentUser = user;
            LoadDashboardData();
            LoadDataTiket();
        }

        // ============================================================
        // LOAD DATA DASHBOARD
        // ============================================================
        private void LoadDashboardData()
        {
            try
            {
                int totalTiket = GetTotalTiketTerjual();
                tbTiket.Text = totalTiket.ToString("N0");

                decimal totalPendapatan = GetTotalPendapatan();
                tbPendapatan.Text = $"Rp {totalPendapatan:N0}";

                int totalPengguna = GetTotalPengguna();
                tbPengguna.Text = totalPengguna.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        // ============================================================
        // QUERY DATABASE
        // ============================================================
        private int GetTotalTiketTerjual()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(jumlah), 0) FROM transaksi WHERE LOWER(status) != 'batal'";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        private decimal GetTotalPendapatan()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(total_harga), 0) FROM transaksi WHERE LOWER(status) != 'batal'";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        private int GetTotalPengguna()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE is_admin = false";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        // ============================================================
        // LOAD DATA TIKET
        // ============================================================
        private void LoadDataTiket(string searchText = "")
        {
            try
            {
                if (dataGridViewTiket == null) return;

                _dataTableTiket = new DataTable();

                _dataTableTiket.Columns.Add("Id Tiket", typeof(string));
                _dataTableTiket.Columns.Add("Nama Pelanggan", typeof(string));
                _dataTableTiket.Columns.Add("Jenis Tiket", typeof(string));
                _dataTableTiket.Columns.Add("Tanggal Berangkat", typeof(string));
                _dataTableTiket.Columns.Add("Jumlah Tiket", typeof(int));
                _dataTableTiket.Columns.Add("Total Harga", typeof(string));
                _dataTableTiket.Columns.Add("Status", typeof(string));
                _dataTableTiket.Columns.Add("Aksi", typeof(string));

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            t.id,
                            t.tanggal_transaksi,
                            t.jenis_tiket,
                            t.jumlah,
                            t.total_harga,
                            t.status,
                            u.nama as nama_pelanggan
                        FROM transaksi t
                        JOIN users u ON t.user_id = u.id
                        WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(searchText) && searchText != "Cari tiket berdasarkan ID, nama, atau jenis...")
                    {
                        query += $@" AND (
                            t.id::text LIKE '%{searchText}%' OR 
                            u.nama ILIKE '%{searchText}%' OR 
                            t.jenis_tiket ILIKE '%{searchText}%'
                        )";
                    }

                    query += " ORDER BY t.tanggal_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int transaksiId = Convert.ToInt32(reader["id"]);
                                string status = reader["status"].ToString() ?? "Aktif";
                                int totalHarga = Convert.ToInt32(reader["total_harga"]);

                                _dataTableTiket.Rows.Add(
                                    $"TIK-{transaksiId:D4}",
                                    reader["nama_pelanggan"].ToString() ?? "-",
                                    reader["jenis_tiket"].ToString() ?? "-",
                                    Convert.ToDateTime(reader["tanggal_transaksi"]).ToString("dd/MM/yyyy"),
                                    Convert.ToInt32(reader["jumlah"]),
                                    $"Rp {totalHarga:N0}",
                                    status,
                                    "Detail"
                                );
                            }
                        }
                    }
                }

                dataGridViewTiket.DataSource = _dataTableTiket;

                dataGridViewTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTiket.ReadOnly = true;
                dataGridViewTiket.AllowUserToAddRows = false;
                dataGridViewTiket.AllowUserToDeleteRows = false;
                dataGridViewTiket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewTiket.MultiSelect = false;
                dataGridViewTiket.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        // ============================================================
        // WARNAKAN STATUS
        // ============================================================
        private void DataGridViewTiket_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewTiket.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";

                switch (status.ToLower())
                {
                    case "aktif":
                        e.CellStyle.BackColor = Color.FromArgb(52, 152, 219);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "selesai":
                        e.CellStyle.BackColor = Color.FromArgb(46, 204, 113);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "batal":
                        e.CellStyle.BackColor = Color.FromArgb(231, 76, 60);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    default:
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        // ============================================================
        // EVENT: SEARCH - TextChanged
        // ============================================================
        private void tbPencarian_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbPencarian.Text.Trim();
            if (searchText == "Cari tiket berdasarkan ID, nama, atau jenis...")
            {
                searchText = "";
            }
            LoadDataTiket(searchText);
        }

        // ============================================================
        // EVENT: TEXTBOX ENTER
        // ============================================================
        private void tbPencarian_Enter(object sender, EventArgs e)
        {
            if (tbPencarian.Text == "Cari tiket berdasarkan ID, nama, atau jenis...")
            {
                tbPencarian.Text = "";
                tbPencarian.ForeColor = Color.Black;
            }
        }

        // ============================================================
        // EVENT: TEXTBOX LEAVE
        // ============================================================
        private void tbPencarian_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPencarian.Text))
            {
                tbPencarian.Text = "Cari tiket berdasarkan ID, nama, atau jenis...";
                tbPencarian.ForeColor = Color.Gray;
            }
        }

        // ============================================================
        // EVENT: DETAIL
        // ============================================================
        private void dataGridViewTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewTiket.Columns["Aksi"]?.Index)
                return;

            try
            {
                DataGridViewRow selectedRow = dataGridViewTiket.Rows[e.RowIndex];

                string idTiket = selectedRow.Cells["Id Tiket"].Value?.ToString() ?? "";
                string tanggal = selectedRow.Cells["Tanggal Berangkat"].Value?.ToString() ?? "";
                string jenisTiket = selectedRow.Cells["Jenis Tiket"].Value?.ToString() ?? "";
                int jumlah = Convert.ToInt32(selectedRow.Cells["Jumlah Tiket"].Value);
                string totalBayar = selectedRow.Cells["Total Harga"].Value?.ToString() ?? "Rp 0";
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                string namaPelanggan = selectedRow.Cells["Nama Pelanggan"].Value?.ToString() ?? "";

                if (_currentUser == null) return;

                // Buat user baru dengan nama pelanggan
                UserModel userPelanggan = new UserModel();  // ✅ UserModel (bukan Models.UserModels)
                userPelanggan.Nama = namaPelanggan;
                userPelanggan.Email = _currentUser.Email ?? "";
                userPelanggan.Id = _currentUser.Id;

                if (jenisTiket.ToLower().Contains("weekend"))
                {
                    DetailTransaksiWy detail = new DetailTransaksiWy(
                        userPelanggan,
                        idTiket,
                        tanggal,
                        jenisTiket,
                        jumlah,
                        totalBayar,
                        status
                    );
                    detail.Show();
                }
                else
                {
                    DetailTransaksiWd detail = new DetailTransaksiWd(
                        userPelanggan,
                        idTiket,
                        tanggal,
                        jenisTiket,
                        jumlah,
                        totalBayar,
                        status
                    );
                    detail.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        // ============================================================
        // EVENT: REFRESH
        // ============================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadDataTiket();
            MessageBox.Show("Data berhasil di-refresh!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================================================
        // EVENT: NAVIGASI
        // ============================================================
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadDataTiket();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Profil profil = new Profil(_currentUser);
                profil.Show();
                this.Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}