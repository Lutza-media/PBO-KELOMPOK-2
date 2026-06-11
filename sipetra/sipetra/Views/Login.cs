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
                Username = tbEmail.Text.Trim(),
                Password = tbKataSandi.Text.Trim()
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
            MessageBox.Show($"Login berhasil. Selamat datang, {user.Username}!");
            return true;
        }

        private void RedirectAfterLogin(User user)
        {

            Form next = new sipetra.Views.Beranda(user.Username);
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
            User user = new User();

            user.Username = tbEmail.Text.Trim();
            user.Password = tbKataSandi.Text.Trim();

            UserControllers controller = new UserControllers();

            bool berhasil = controller.Login(user);

            if (berhasil)
            {
                MessageBox.Show("Login Berhasil");

                Beranda beranda = new Beranda(user.Username);
                beranda.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
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
