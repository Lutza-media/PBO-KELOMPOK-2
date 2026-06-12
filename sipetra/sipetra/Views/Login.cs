using Microsoft.Win32;
using sipetra.Controllers;
using sipetra.Helpers;
using sipetra.Models;
using sipetra.Views;
using System;
using System.Windows.Forms;


namespace sipetra.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Email harus diisi!");
                    tbEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbKataSandi.Text))
                {
                    MessageBox.Show("Password harus diisi!");
                    tbKataSandi.Focus();
                    return;
                }

                User user = new User();

                user.Email = tbEmail.Text.Trim();
                user.Password = tbKataSandi.Text.Trim();

                bool loginBerhasil = user.Login();

                if (loginBerhasil)
                {
                    user.LoadUserData();

                    MessageBox.Show(
                        "Login berhasil!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Beranda beranda = new Beranda(user.Nama);

                    beranda.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Email atau Password salah!",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblDaftar_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Show();

            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}