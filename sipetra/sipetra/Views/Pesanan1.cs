using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views.NewFolder
{
    public partial class Pesanan1 : Form
    {
        private User _currentUser;

        public Pesanan1()
        {
            InitializeComponent();
        }

        public Pesanan1(User user) : this()
        {
            _currentUser = user;
        }

        private void Pesanan1_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = 1;
        }

        // KETIKA KLIK "LANJUTKAN PEMBAYARAN" - KIRIM DATA KE PEMBAYARAN
        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            int jumlahTiket = (int)numericUpDown1.Value;
            DateTime tanggalKunjungan = dateTimePicker2.Value;
            int hargaPerTiket = 7500; // Weekday price
            string jenisTiket = "Weekday";

            // Kirim data ke form Pembayaran
            Pembayaran pembayaran = new Pembayaran(_currentUser, jenisTiket, jumlahTiket, hargaPerTiket);
            pembayaran.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(_currentUser);
            tiket.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser);
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(_currentUser);
            tiket.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(_currentUser);
            transaksi.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
            this.Hide();
        }
    }
}