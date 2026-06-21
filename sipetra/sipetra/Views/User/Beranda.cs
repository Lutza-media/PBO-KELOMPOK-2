using System;
using System.Windows.Forms;
using sipetra.Helpers;
using sipetra.Models;

namespace sipetra.Views.User
{
    public partial class Beranda : Form, IFormNavigator
    {
        // ✅ UserModel BUKAN User
        private UserModel currentUser;
        private Form previousForm;

        public Beranda()
        {
            InitializeComponent();
        }

        public Beranda(UserModel user)  // ✅ UserModel
        {
            InitializeComponent();
            SetUserData(user);
        }

        public Beranda(UserModel user, Form previous)  // ✅ UserModel
        {
            InitializeComponent();
            SetUserData(user);
            previousForm = previous;
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetUserData(UserModel user)  // ✅ UserModel
        {
            currentUser = user;
            if (currentUser == null)
            {
                MessageBox.Show("Peringatan: User data is NULL!");
            }
            this.Text = "Beranda - " + user?.Nama;
        }

        public void NavigateTo(Form targetForm)
        {
            targetForm.Show();
            this.Hide();
        }

        public void GoBack()
        {
            if (previousForm != null)
            {
                previousForm.Show();
                this.Close();
            }
        }

        private void Beranda_Load(object sender, EventArgs e) { }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(currentUser);
            NavigateTo(tiket);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(currentUser);
            NavigateTo(transaksi);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(currentUser);
            NavigateTo(profil);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void butBeranda_Click(object sender, EventArgs e) { }
    }
}