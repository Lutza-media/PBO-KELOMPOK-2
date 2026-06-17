using System;
using System.Windows.Forms;
using sipetra.Models;
namespace sipetra.Views
{
    public partial class Transaksi : Form
    {
        private User _currentUser;

        public Transaksi()
        {
            InitializeComponent();
        }

        public Transaksi(User user) : this()
        {
            _currentUser = user;
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket();
            tiket.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Ptrofil profil = new Ptrofil();
            profil.Show();
            this.Hide();
        }

        private void btnDetailTransaksi_Click(object sender, EventArgs e)
        {
            DetailTransaksi detail = new DetailTransaksi();
            detail.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e)
        {
            btnDetailTransaksi_Click(sender, e);
        }

        private void btnPesanTiketWeekend_Click(object sender, EventArgs e)
        {
            Riwayat riwayat = new Riwayat();
            riwayat.Show();
            this.Hide();
        }

        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda sedang berada di halaman Data Transaksi");
        }
    }
}
