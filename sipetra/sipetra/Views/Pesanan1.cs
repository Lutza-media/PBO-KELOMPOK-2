using System;
using System.Windows.Forms;
using sipetra.Views;
using sipetra.Models;

namespace sipetra.Views.NewFolder
{
    public partial class Pesanan1 : Form
    {
        private User _currentUser;  // <-- TAMBAHKAN INI

        public Pesanan1()
        {
            InitializeComponent();
        }

        // TAMBAHKAN CONSTRUCTOR DENGAN USER
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

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            int jumlahTiket = (int)numericUpDown1.Value;
            DateTime tanggalKunjungan = dateTimePicker2.Value;
            int hargaPerTiket = 7500; // Weekday price
            int totalHarga = jumlahTiket * hargaPerTiket;

            // Kirim user ke Pembayaran
            Pembayaran pembayaran = new Pembayaran(_currentUser);  
            pembayaran.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Kirim user ke Tiket
            Tiket tiket = new Tiket(_currentUser);  // <-- PERBAIKI
            tiket.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser);  // <-- PERBAIKI
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(_currentUser);  // <-- PERBAIKI
            tiket.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(_currentUser);  // <-- PERBAIKI
            transaksi.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);  // <-- PERBAIKI
            profil.Show();
            this.Hide();
        }
    }
}