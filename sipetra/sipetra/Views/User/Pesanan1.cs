using System;
using System.Windows.Forms;
using sipetra.Models;
using sipetra.Views;
using sipetra.Views.User;



namespace sipetra.Views.User
{
    public partial class Pesanan1 : Form
    {
        // ✅ UserModel BUKAN User
        private UserModel _currentUser;

        public Pesanan1()
        {
            InitializeComponent();
        }

        public Pesanan1(UserModel user) : this()  // ✅ UserModel
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
            int hargaPerTiket = 7500;
            string jenisTiket = "Weekday";

            Pembayaran pembayaran = new Pembayaran(_currentUser, jenisTiket, jumlahTiket, hargaPerTiket);
            pembayaran.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Views.User.Tiket tiket = new Views.User.Tiket(_currentUser);
            tiket.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Views.User.Beranda beranda = new Views.User.Beranda(_currentUser);
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Views.User.Tiket tiket = new Views.User.Tiket(_currentUser);
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