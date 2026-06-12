using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Daftar : Form
    {
        public Daftar()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi Input
                if (string.IsNullOrWhiteSpace(tbNama.Text))
                {
                    MessageBox.Show(
                        "Nama tidak boleh kosong!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbNama.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show(
                        "Email tidak boleh kosong!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    MessageBox.Show(
                        "Password tidak boleh kosong!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbPassword.Focus();
                    return;
                }

                if (tbPassword.Text != tbKonfirmasiPassword.Text)
                {
                    MessageBox.Show(
                        "Konfirmasi password tidak sesuai!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbKonfirmasiPassword.Focus();
                    return;
                }

                // Membuat objek User
                User user = new User();

                user.Nama = tbNama.Text.Trim();
                user.Email = tbEmail.Text.Trim();
                user.Password = tb.Text.Trim();

                bool berhasil = user.Register();

                if (berhasil)
                {
                    MessageBox.Show(
                        "Registrasi berhasil!",
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
                        "Registrasi gagal!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }

        private void Daftar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            tbNama.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            tbKonfirmasiPassword.Clear();

            tbNama.Focus();
        }
    }
}