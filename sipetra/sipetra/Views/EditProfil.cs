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
                MessageBox.Show("Data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan data di TextBox
            btnNamaLengkap.Text = _currentUser.Nama;
            btnEmail.Text = _currentUser.Email;
        }

        // ============================================================
        // TOMBOL SIMPAN - UPDATE DATABASE DAN KEMBALI KE PROFIL
        // ============================================================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi Nama
                if (string.IsNullOrWhiteSpace(btnNamaLengkap.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNamaLengkap.Focus();
                    return;
                }

                // Validasi Email
                if (string.IsNullOrWhiteSpace(btnEmail.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnEmail.Focus();
                    return;
                }

                if (!btnEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Format email tidak valid! Harus mengandung @", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnEmail.Focus();
                    return;
                }

                // Update ke database
                bool berhasil = _currentUser.UpdateProfil(
                    btnNamaLengkap.Text.Trim(),
                    btnEmail.Text.Trim()
                );

                if (berhasil)
                {
                    MessageBox.Show(" Profil berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kembali ke Profil dengan data terbaru
                    Profil profil = new Profil(_currentUser);
                    profil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Gagal mengupdate profil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // TOMBOL BATAL - KEMBALI TANPA MENYIMPAN
        // ============================================================
        private void btnBatal_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
            this.Hide();
        }

        // ============================================================
        // NAVIGASI
        // ============================================================
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