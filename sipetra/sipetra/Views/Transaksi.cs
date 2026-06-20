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
        }

        public Transaksi(User user) : this()
        {
            _currentUser = user;
            LoadDataTransaksi();
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
                dt.Columns.Add("Id Transaksi", typeof(string));  // ← DIUBAH JADI STRING
                dt.Columns.Add("Tanggal", typeof(string));
                dt.Columns.Add("Jenis Tiket", typeof(string));
                dt.Columns.Add("Jumlah", typeof(int));
                dt.Columns.Add("Total Bayar", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                int counter = 1;
                foreach (var t in transaksiList)
                {
                    dt.Rows.Add(
                        $"TRX{counter:D4}",  // ← FORMAT TRX0001, TRX0002, dst
                        t.TanggalTransaksi.ToString("dd/MM/yyyy HH:mm"),
                        t.JenisTiket,
                        t.Jumlah,
                        $"Rp {t.TotalHarga:N0}",
                        t.Status
                    );
                    counter++;
                }

                dataGridViewTransaksi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDetailTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTransaksi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih transaksi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DetailTransaksiWd detail = new DetailTransaksiWd(_currentUser);
                detail.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kosongkan
        }
    }
}