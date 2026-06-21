using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sipetra.Models;


namespace sipetra.Views  // ✅ UBAH DARI sipetra.Views.User MENJADI sipetra.Views (agar sama dengan designer)
{
    public partial class Riwayat : Form
    {
        private UserModel _currentUser;

        public Riwayat()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
        }

        public Riwayat(UserModel user) : this()
        {
            _currentUser = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(_currentUser);
            transaksi.Show();
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

        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            // ✅ TAMPILKAN FORM TRANSAKSI
            Transaksi transaksi = new Transaksi(_currentUser);
            transaksi.Show();
            this.Hide();
        }

        // ✅ TAMBAHKAN METHOD INI UNTUK btnProfil
        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
            this.Hide();
        }

        // ✅ TAMBAHKAN METHOD UNTUK button1 (jika diperlukan)
        private void button1_Click(object sender, EventArgs e)
        {
            // Kosongkan atau tambahkan logika
        }
    }
}
