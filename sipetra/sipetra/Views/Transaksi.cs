// Transaksi.cs - Tambahkan event handler untuk CellClick atau CellDoubleClick

using System;
using System.Windows.Forms;
using System.Data;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Transaksi : Form
    {
        private User _currentUser;

        public Transaksi()
        {
            InitializeComponent();
            pictureBox1.SendToBack();

            // Tambahkan event handler untuk CellDoubleClick
            dataGridViewTransaksi.CellDoubleClick += DataGridViewTransaksi_CellDoubleClick;

            // Atau bisa pakai CellClick (single click)
            // dataGridViewTransaksi.CellClick += DataGridViewTransaksi_CellClick;
        }

        public Transaksi(User user) : this()
        {
            _currentUser = user;
            LoadDataTransaksi();
            InitializeContextMenu();
        } 

        private void LoadDataTransaksi()
        {
            if (_currentUser == null)
            {
                MessageBox.Show("User tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var transaksiList = TransaksiModel.GetByUserId(_currentUser.Id);

                DataTable dt = new DataTable();
                dt.Columns.Add("Id Transaksi", typeof(string));
                dt.Columns.Add("Tanggal", typeof(string));
                dt.Columns.Add("Jenis Tiket", typeof(string));
                dt.Columns.Add("Jumlah", typeof(int));
                dt.Columns.Add("Total Bayar", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                int counter = 1;
                foreach (var t in transaksiList)
                {
                    dt.Rows.Add(
                        $"TRX{counter:D4}",
                        t.TanggalTransaksi.ToString("dd/MM/yyyy HH:mm"),
                        t.JenisTiket,
                        t.Jumlah,
                        $"Rp {t.TotalHarga:N0}",
                        t.Status
                    );
                    counter++;
                }

                dataGridViewTransaksi.DataSource = dt;

                // Atur tampilan DataGridView
                dataGridViewTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTransaksi.ReadOnly = true;
                dataGridViewTransaksi.AllowUserToAddRows = false;
                dataGridViewTransaksi.AllowUserToDeleteRows = false;

                // Atur warna dan style
                dataGridViewTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewTransaksi.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // EVENT: DOUBLE CLICK PADA DATAGRIDVIEW
        // ============================================================
        private void DataGridViewTransaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek apakah klik pada baris yang valid (bukan header)
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewTransaksi.Rows.Count)
                return;

            try
            {
                DataGridViewRow selectedRow = dataGridViewTransaksi.Rows[e.RowIndex];

                // Ambil data dari kolom
                string idTransaksi = selectedRow.Cells["Id Transaksi"].Value?.ToString() ?? "";
                string tanggal = selectedRow.Cells["Tanggal"].Value?.ToString() ?? "";
                string jenisTiket = selectedRow.Cells["Jenis Tiket"].Value?.ToString() ?? "";
                int jumlah = Convert.ToInt32(selectedRow.Cells["Jumlah"].Value);
                string totalBayar = selectedRow.Cells["Total Bayar"].Value?.ToString() ?? "";
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

                // Tampilkan detail berdasarkan jenis tiket
                ShowDetailTransaksi(idTransaksi, tanggal, jenisTiket, jumlah, totalBayar, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // EVENT: SINGLE CLICK PADA DATAGRIDVIEW (Alternatif)
        // ============================================================
        private void DataGridViewTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek apakah klik pada baris yang valid (bukan header)
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewTransaksi.Rows.Count)
                return;

            try
            {
                DataGridViewRow selectedRow = dataGridViewTransaksi.Rows[e.RowIndex];

                string idTransaksi = selectedRow.Cells["Id Transaksi"].Value?.ToString() ?? "";
                string tanggal = selectedRow.Cells["Tanggal"].Value?.ToString() ?? "";
                string jenisTiket = selectedRow.Cells["Jenis Tiket"].Value?.ToString() ?? "";
                int jumlah = Convert.ToInt32(selectedRow.Cells["Jumlah"].Value);
                string totalBayar = selectedRow.Cells["Total Bayar"].Value?.ToString() ?? "";
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

                ShowDetailTransaksi(idTransaksi, tanggal, jenisTiket, jumlah, totalBayar, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // METHOD UNTUK MENAMPILKAN DETAIL TRANSAKSI
        // ============================================================
        private void ShowDetailTransaksi(string idTransaksi, string tanggal, string jenisTiket, int jumlah, string totalBayar, string status)
        {
            // CEK JENIS TIKET
            if (jenisTiket.ToLower().Contains("weekend"))
            {
                DetailTransaksiWy detail = new DetailTransaksiWy(
                    _currentUser,
                    idTransaksi,
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
                    _currentUser,
                    idTransaksi,
                    tanggal,
                    jenisTiket,
                    jumlah,
                    totalBayar,
                    status
                );
                detail.Show();
            }

            this.Hide();
        }

        // ============================================================
        // TOMBOL DETAIL - Tetap dipertahankan
        // ============================================================
        private void btnDetailTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTransaksi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih transaksi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewTransaksi.SelectedRows[0];

                string idTransaksi = selectedRow.Cells["Id Transaksi"].Value?.ToString() ?? "";
                string tanggal = selectedRow.Cells["Tanggal"].Value?.ToString() ?? "";
                string jenisTiket = selectedRow.Cells["Jenis Tiket"].Value?.ToString() ?? "";
                int jumlah = Convert.ToInt32(selectedRow.Cells["Jumlah"].Value);
                string totalBayar = selectedRow.Cells["Total Bayar"].Value?.ToString() ?? "";
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

                ShowDetailTransaksi(idTransaksi, tanggal, jenisTiket, jumlah, totalBayar, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // NAVIGASI LAINNYA
        // ============================================================
        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            LoadDataTransaksi();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Riwayat riwayat = new Riwayat(_currentUser);
                riwayat.Show();
                this.Hide();
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Beranda beranda = new Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Tiket tiket = new Tiket(_currentUser);
                tiket.Show();
                this.Hide();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Kosongkan
        }

        // Transaksi.cs - Tambahkan ContextMenuStrip

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem menuDetail = new ToolStripMenuItem("Lihat Detail");
            menuDetail.Click += (s, e) => btnDetailTransaksi_Click(s, e);
            contextMenu.Items.Add(menuDetail);

            ToolStripMenuItem menuRefresh = new ToolStripMenuItem("Refresh Data");
            menuRefresh.Click += (s, e) => LoadDataTransaksi();
            contextMenu.Items.Add(menuRefresh);

            dataGridViewTransaksi.ContextMenuStrip = contextMenu;
        }

        private void SetupDataGridView()
        {
            // Tambahkan ToolTip
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(dataGridViewTransaksi, "Double-klik pada baris untuk melihat detail transaksi");

            // Atur cursor menjadi Hand saat hover
            dataGridViewTransaksi.Cursor = Cursors.Hand;
        }
    }
}