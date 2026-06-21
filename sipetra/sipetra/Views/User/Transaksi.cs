// Transaksi.cs - Tambahkan event handler untuk CellClick atau CellDoubleClick

using sipetra.Models;
using sipetra.Views.User;
using System;
using System.Data;
using System.Windows.Forms;

namespace sipetra.Views
{
    public partial class Transaksi : Form
    {
        // ✅ UserModel BUKAN User
        private UserModel _currentUser;

        public Transaksi()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
            dataGridViewTransaksi.CellDoubleClick += DataGridViewTransaksi_CellDoubleClick;
        }

        public Transaksi(UserModel user) : this()  // ✅ UserModel
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

                dataGridViewTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTransaksi.ReadOnly = true;
                dataGridViewTransaksi.AllowUserToAddRows = false;
                dataGridViewTransaksi.AllowUserToDeleteRows = false;
                dataGridViewTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewTransaksi.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewTransaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void ShowDetailTransaksi(string idTransaksi, string tanggal, string jenisTiket, int jumlah, string totalBayar, string status)
        {
            if (jenisTiket.ToLower().Contains("weekend"))
            {
                Views.User.DetailTransaksiWy detail = new Views.User.DetailTransaksiWy(
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
                Views.User.DetailTransaksiWd detail = new Views.User.DetailTransaksiWd(
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
                Views.User.Beranda beranda = new Views.User.Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Views.User.Tiket tiket = new Views.User.Tiket(_currentUser);
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

        private void button1_Click(object sender, EventArgs e) { }

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
    }
}