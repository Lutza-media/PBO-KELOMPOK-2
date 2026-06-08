using sipetra.Controllers;
using sipetra.Models;
using sipetra.Helpers;
using sipetra.Views;
using System;
using System.Windows.Forms;

namespace sipetra.Views
{
    public partial class Login : Form
    {
        UserControllers userController = new UserControllers();
        public Login()
        {
            InitializeComponent();
        }

        private bool ValidateLoginInput()
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbKataSandi.Text))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong.");
                return false;
            }
            return true;
        }

        private User GetLoginRequest()
        {
            return new User
            {
                email = tbEmail.Text.Trim(),
                katasandi = tbKataSandi.Text.Trim()
            };
        }

        private bool HandleLoginResult(User user)
        {
            if (user == null)
            {
                MessageBox.Show("Login gagal. Kata Sandi atau Email salah!");
                return false;
            }
            UserSession.Instance.SetUser(user);
            MessageBox.Show($"Login berhasil. Selamat datang, {user.nama}!");
            return true;
        }

        private void RedirectAfterLogin(User user)
        {

            Form next = new sipetra.Views.Beranda(user);
            next.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginInput())
                return;

            var req = GetLoginRequest();
            var result = userController.Login(req);

            if (!HandleLoginResult(result))
                return;

            RedirectAfterLogin(result);
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Daftar daftar = new Daftar();
            daftar.Show();
            this.Hide();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == true)
            {
                tbKataSandi.UseSystemPasswordChar = false;
            }
            else
            {
                tbKataSandi.UseSystemPasswordChar = true;
            }
        }
    }
}
