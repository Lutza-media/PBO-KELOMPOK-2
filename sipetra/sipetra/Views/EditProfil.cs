using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class EditProfil : Form
    {
        private User _currentUser;

        public EditProfil()
        {
            InitializeComponent();
        }

        public EditProfil(User user) : this()
        {
            _currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Data user tidak ditemukan!");
                return;
            }

            btnNamaLengkap.Text = _currentUser.Nama;
            btnEmailEdit.Text = _currentUser.Email;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(btnNamaLengkap.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNamaLengkap.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(btnEmailEdit.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnEmailEdit.Focus();
                    return;
                }

                // Gunakan _currentUser yang sudah ada, bukan user baru
                if (_currentUser == null)
                {
                    _currentUser = new User();
                    if (!_currentUser.LoadUserData())
                    {
                        MessageBox.Show("Gagal memuat data user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Perbaikan: gunakan UpdateProfil (tanpa huruf e di akhir) bukan UpdateProfile
                bool berhasil = _currentUser.UpdateProfil(btnNamaLengkap.Text.Trim(), btnEmailEdit.Text.Trim());

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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatalEdit_Click(object sender, EventArgs e)
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

        // Event handler untuk Designer (biarkan kosong)
        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            // Kosongkan saja
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Kosongkan saja
        }

        private void btnTiket_Click_1(object sender, EventArgs e)
        {
            btnTiket_Click(sender, e);
        }

        private void bntProfil_Click(object sender, EventArgs e)
        {
            btnProfil_Click(sender, e);
        }
    }
}