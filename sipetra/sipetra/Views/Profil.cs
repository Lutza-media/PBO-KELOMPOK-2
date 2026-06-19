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
                MessageBox.Show("Error: Data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnNamaLengkap.Text = _currentUser.Nama;
            btnEmail.Text = _currentUser.Email;
            this.Text = $"Profil - {_currentUser.Nama}";
        }

        // TOMBOL EDIT PROFIL - KE HALAMAN EDIT PROFIL
        private void tbEditProfil_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Error: Tidak dapat mengedit profil, data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditProfil editProfil = new EditProfil(_currentUser);
            editProfil.Show();
            this.Hide();
        }

        // NAVIGASI
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Beranda beranda = new Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Beranda beranda = new Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Tiket tiket = new Tiket(_currentUser);
                tiket.Show();
                this.Hide();
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Transaksi transaksi = new Transaksi(_currentUser);
                transaksi.Show();
                this.Hide();
            }
        }

        private void bntProfil_Click(object sender, EventArgs e)
        {
            tbEditProfil_Click(sender, e);
        }
    }
}