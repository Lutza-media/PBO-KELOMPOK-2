using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views.User
{
    public partial class EditProfil : Form
    {
        private UserModel _currentUser;

        public EditProfil()
        {
            InitializeComponent();
        }

        public EditProfil(UserModel user) : this()
        {
            _currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Gunakan txtNamaLengkap (sesuai designer)
            tbNamaLengkap.Text = _currentUser.Nama;
            tbEmail.Text = _currentUser.Email;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNamaLengkap.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNamaLengkap.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                if (!tbEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Format email tidak valid! Harus mengandung @", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                bool berhasil = _currentUser.UpdateProfil(
                    tbNamaLengkap.Text.Trim(),
                    tbEmail.Text.Trim()
                );

                if (berhasil)
                {
                    MessageBox.Show("Profil berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Profil profil = new Profil(_currentUser);
                    profil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal mengupdate profil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
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