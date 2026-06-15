using System;
using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Pesanan2 : Form
    {
        // Pesanan2.cs
        private User _currentUser;

        public Pesanan2()
        {
            InitializeComponent();
        }

        public Pesanan2(User user) : this()
        {
            _currentUser = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void Pesanan2_Load(object sender, EventArgs e)
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
            int hargaPerTiket = 12000; // Weekend price
            int totalHarga = jumlahTiket * hargaPerTiket;

            Pembayaran pembayaran = new Pembayaran();
            pembayaran.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket();
            tiket.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Ptrofil profil = new Ptrofil();
            profil.Show();
            this.Hide();
        }
    }
}