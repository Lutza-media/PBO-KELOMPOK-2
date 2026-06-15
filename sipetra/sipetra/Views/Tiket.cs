using sipetra.Views;
using sipetra.Models;
using System;
using System.Windows.Forms;

namespace sipetra
{
    public partial class Tiket : Form
    {
        private User _currentUser;

        public Tiket()
        {
            InitializeComponent();
        }
        public Tiket(User user) : this()
        {
            _currentUser = user;
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser);  // Kirim user
            beranda.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Ptrofil profil = new Ptrofil(_currentUser);  // Kirim user
            profil.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(_currentUser);  // Perlu menambahkan constructor ini
            transaksi.Show();
            this.Hide();
        }

        // Tiket.cs
        private void btnPesanTiketWeekday_Click(object sender, EventArgs e)
        {
            Views.NewFolder.Pesanan1 pesanan = new Views.NewFolder.Pesanan1();
            pesanan.Show();
            this.Hide();
        }

        private void btnPesanTiketWeekend_Click(object sender, EventArgs e)
        {
            Views.Pesanan2 pesanan = new Views.Pesanan2();
            pesanan.Show();
            this.Hide();
        }

        private void Tiket_Load(object sender, EventArgs e)
        {
            // Any initialization code
        }

        private void Tiket_Load_1(object sender, EventArgs e)
        {
            // Kode load jika diperlukan, atau kosongkan saja
        }

        private void btnPesanTiket1_Click(object sender, EventArgs e)
        {
            // Panggil method yang sudah ada
            btnPesanTiketWeekday_Click(sender, e);
        }


    }
}
