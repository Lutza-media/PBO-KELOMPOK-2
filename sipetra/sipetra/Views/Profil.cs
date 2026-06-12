using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sipetra.Models; // ← TAMBAHKAN INI

namespace sipetra.Views
{
    public partial class Profil : Form
    {
        private User _currentUser; // ← TAMBAHKAN INI

        public Profil()
        {
            InitializeComponent();
        }

        // ← TAMBAHKAN CONSTRUCTOR INI
        public Profil(User user) : this()
        {
            _currentUser = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void Profil_Load(object sender, EventArgs e) { }

        // Tombol kembali ke Beranda
        private void button1_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser.Nama);
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket();
            tiket.Show();
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
            // sudah di halaman Profil, tidak perlu navigasi
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void bntProfil_Click(object sender, EventArgs e) { }
    }
}