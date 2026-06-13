using System;
using System.Windows.Forms;

namespace sipetra.Views
{
    public partial class Beranda : Form
    {
        private string username;


        public Beranda(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public Beranda()
        {
            InitializeComponent();
        }

        private void Beranda_Load(object sender, EventArgs e)
        {
            this.Text = "Beranda - " + username;
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Tiket");
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            // kode transaksi
        }

        private void butBeranda_Click(object sender, EventArgs e)
        {

        }
    }
}