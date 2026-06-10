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

        private void Beranda_Load(object sender, EventArgs e)
        {
            this.Text = "Beranda - " + username;
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Tiket");
        }
    }
}