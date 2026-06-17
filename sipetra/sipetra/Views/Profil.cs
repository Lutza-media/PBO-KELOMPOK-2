using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Profil : Form
    {
        private User _currentUser;

        public Profil()
        {
            InitializeComponent();
        }

        public Profil(User user) : this()
        {
            _currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Error: Data user tidak ditemukan!");
                return;
            }

            // Tampilkan data user di form
            // Contoh: lblNama.Text = _currentUser.Nama;
            //         lblEmail.Text = _currentUser.Email;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser);
            beranda.Show();
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

        private void btnEditProfil_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Error: Tidak dapat mengedit profil, data user tidak ditemukan!");
                return;
            }

            EditProfil editProfil = new EditProfil(_currentUser);
            editProfil.Show();
            this.Hide();
        }

        private void bntProfil_Click(object sender, EventArgs e)
        {
            btnEditProfil_Click(sender, e);
        }
    }
}