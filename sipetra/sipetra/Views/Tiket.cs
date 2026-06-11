using sipetra.Views;
using sipetra.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sipetra
{
    public partial class Tiket : Form
    {

        public Tiket()
        {
            InitializeComponent();

            btnPesanTiketWeekend.Click += btnPesanTiketWeekend_Click;
        }

        private User _currentUser;
        public Tiket(User user) : this()
        {
            _currentUser = user;
        }

        private void Tiket_Load(object sender, EventArgs e)
        {
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
            //Profil profil = new Profil();
            //profil.Show();
            //this.Hide();
        }

        private void btnPesanTiket1_Click(object sender, EventArgs e)
        {
            Pemesanan_Tiket formPesan = new Pemesanan_Tiket(
                "Tiket Weekday",
                "Rp7.500 / orang",
                Properties.Resources.weekday // gambar tiket weekday
            );

            formPesan.Show();
            this.Hide();
        }

        private void btnPesanTiketWeekend_Click(object sender, EventArgs e)
        {
            Pemesanan_Tiket formPesan = new Pemesanan_Tiket(
                "Tiket Weekend",
                "Rp12.000 / orang",
                Properties.Resources.weekend // gambar tiket weekend
            );

            formPesan.Show();
            this.Hide();
        }
        private void Tiket_Load_1(object sender, EventArgs e)
        {

        }
    }
}
