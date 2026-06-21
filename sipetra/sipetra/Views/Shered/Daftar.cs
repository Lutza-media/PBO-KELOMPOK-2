using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views.Shared
{
    public partial class Daftar : Form
    {
        public Daftar()
        {
            InitializeComponent();
        }

        private void Daftar_Load(object sender, EventArgs e) { }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNama.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNama.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbKataSandi.Text))
                {
                    MessageBox.Show("Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbKataSandi.Focus();
                    return;
                }

                if (tbKataSandi.Text.Length < 6)
                {
                    MessageBox.Show("Password minimal 6 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbKataSandi.Focus();
                    return;
                }

                // ✅ UserModel BUKAN User
                UserModel user = new UserModel();
                user.Nama = tbNama.Text.Trim();
                user.Email = tbEmail.Text.Trim();
                user.Password = tbKataSandi.Text.Trim();
                user.IsAdmin = false;

                bool berhasil = user.Register();

                if (berhasil)
                {
                    MessageBox.Show(
                        "✅ Registrasi berhasil! Silakan login.",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "❌ Registrasi gagal! Silakan coba lagi.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            tbNama.Clear();
            tbEmail.Clear();
            tbKataSandi.Clear();
            tbNama.Focus();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            tbKataSandi.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void Daftar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}