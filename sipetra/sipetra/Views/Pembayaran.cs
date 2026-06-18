using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Pembayaran : Form
    {
        private User _currentUser;  // <-- TAMBAHKAN INI

        public Pembayaran()
        {
            InitializeComponent();
        }

        // TAMBAHKAN CONSTRUCTOR DENGAN USER
        public Pembayaran(User user) : this()
        {
            _currentUser = user;
        }

        private void Pembayaran_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}