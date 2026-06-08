using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
        }

        private User _currentUser;
        public Beranda(User user) : this()
        {
            _currentUser = user;
        }

        private void Beranda_Load(object sender, EventArgs e)
        {
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket();
            tiket.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            //Transaksi transaksi = new Transaksi();
            //transaksi.Show();
            //this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            //Profil profil = new Profil();
            //            profil.Show();
        }
    }
}
