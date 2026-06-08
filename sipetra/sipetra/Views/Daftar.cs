using sipetra.Controllers;
using sipetra.Models;
using sipetra.Helpers;
using sipetra.Views;
using System;
using System.Windows.Forms;
using Npgsql;
using System.Diagnostics.Eventing.Reader;

namespace sipetra.Views
{
    public partial class Daftar : Form
    {
        private readonly UserControllers userControllers = new UserControllers();

        public Daftar()
        {
            InitializeComponent();
        }

        private void Daftar_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateRegistrationInput()
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbKataSandi.Text))
            {
                MessageBox.Show("Nama, Email, dan Kata Sandi tidak boleh kosong.");
                return false;
            }

            else if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
            {
                MessageBox.Show("Format email tidak valid.");
                return false;
            }

            else if (!tbKataSandi.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Kata Sandi harus mengandung angka.");
                return false;
            }

            else if (tbKataSandi.Text.Length < 6)
            {
                MessageBox.Show("Kata Sandi harus terdiri dari minimal 6 karakter.");
                return false;

            }

            else if (userControllers.CheckEmail(tbEmail.Text.Trim()))
            {
                MessageBox.Show("Email sudah terdaftar. Silakan gunakan email lain.");
                return false;
            }

            return true;

        }

        private User GetRegisterRequest()
        {
            return new User
            {
                nama = tbNama.Text.Trim(),
                email = tbEmail.Text.Trim(),
                katasandi = tbKataSandi.Text.Trim(),
                isAdmin = false
            };

        }

        private void ClearRegisterForm()
        {
            tbNama.Text = "";
            tbEmail.Text = "";
            tbKataSandi.Text = "";
        }

        private void HandleRegistrationResult(User newUser)
        {
            userControllers.RegisterUser(newUser);
            MessageBox.Show("Pendaftaran berhasil. Silakan login dengan akun Anda.");
            ClearRegisterForm();
        }

        private void RedirectAfterRegistration()
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistrationInput())
                return;

            try
            {
                var req = GetRegisterRequest();
                HandleRegistrationResult(req);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mendaftar: {ex.Message}");
            }
            RedirectAfterRegistration();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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