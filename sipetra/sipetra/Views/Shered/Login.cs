using System;
using System.Windows.Forms;
using sipetra.Models;
using sipetra.Views.Admin;

namespace sipetra.Views.Shared
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Email harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbKataSandi.Text))
                {
                    MessageBox.Show("Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbKataSandi.Focus();
                    return;
                }

                // ✅ UserModel BUKAN User
                UserModel user = new UserModel();
                user.Email = tbEmail.Text.Trim();
                user.Password = tbKataSandi.Text.Trim();

                bool loginBerhasil = user.Login();

                if (loginBerhasil)
                {
                    user.LoadUserData();

                    MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.IsAdmin)
                    {
                        Dashboard adminDashboard = new Dashboard(user);
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        Views.User.Beranda beranda = new Views.User.Beranda(user);
                        beranda.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Email atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDaftar_Click(object sender, EventArgs e)
        {
            Daftar daftar = new Daftar();
            daftar.Show();
            this.Hide();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Daftar daftar = new Daftar();
            daftar.Show();
            this.Hide();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            tbKataSandi.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}