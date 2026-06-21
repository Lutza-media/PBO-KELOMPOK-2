using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Profil : Form
    {
        // ✅ UserModel BUKAN User
        private UserModel _currentUser;

        public Profil()
        {
            InitializeComponent();
        }

        public Profil(UserModel user) : this()  // ✅ UserModel
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

            tbNamaLengkap.Text = _currentUser.Nama;
            tbEmail.Text = _currentUser.Email;
            this.Text = $"Profil - {_currentUser.Nama}";
        }

        private void btnEditProfil_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Error: Tidak dapat mengedit profil, data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Views.User.EditProfil editProfil = new Views.User.EditProfil(_currentUser);
            editProfil.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Views.User.Beranda beranda = new Views.User.Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Views.User.Beranda beranda = new Views.User.Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Views.User.Tiket tiket = new Views.User.Tiket(_currentUser);
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

        private void btnProfil_Click(object sender, EventArgs e)
        {
            btnEditProfil_Click(sender, e);
        }
    }
}