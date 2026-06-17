using System;
using System.Windows.Forms;
using sipetra.Helpers;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class Beranda : Form, IFormNavigator
    {
        private User currentUser;
        private Form previousForm;

        public Beranda()
        {
            InitializeComponent();
        }

        public Beranda(User user)
        {
            InitializeComponent();
            SetUserData(user);
        }

        public Beranda(User user, Form previous)
        {
            InitializeComponent();
            SetUserData(user);
            previousForm = previous;
        }

        // Implementasi Interface
        public void ShowForm()
        {
            this.Show();
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetUserData(User user)
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

        // Event Handlers
        private void Beranda_Load(object sender, EventArgs e)
        {
            // Kode saat form loading
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(currentUser);
            NavigateTo(tiket);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            NavigateTo(transaksi);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void butBeranda_Click(object sender, EventArgs e)
        {
            // Kode untuk tombol beranda
            // Contoh: refresh data atau scroll ke atas
        }
    }
}