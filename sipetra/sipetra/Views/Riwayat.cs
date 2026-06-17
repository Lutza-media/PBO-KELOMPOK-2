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

namespace sipetra.Views
{
    public partial class Riwayat : Form
    {
        private User _currentUser;

        public Riwayat()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
        }

        public Riwayat(User user) : this()
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
            Beranda beranda = new Beranda(_currentUser);
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(_currentUser);
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
