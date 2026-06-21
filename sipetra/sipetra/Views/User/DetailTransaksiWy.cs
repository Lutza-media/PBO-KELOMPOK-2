using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views.User
{
    public partial class DetailTransaksiWy : Form
    {
        private UserModel? _currentUser;  // ✅ UserModel (bukan UserModels)
        private string _idTransaksi = "";
        private string _tanggal = "";
        private string _jenisTiket = "";
        private int _jumlah = 0;
        private string _totalBayar = "";
        private string _status = "";

        public DetailTransaksiWy()
        {
            InitializeComponent();
        }

        public DetailTransaksiWy(UserModel user, string idTransaksi, string tanggal, string jenisTiket, int jumlah, string totalBayar, string status) : this()
        {
            _currentUser = user;
            _idTransaksi = idTransaksi;
            _tanggal = tanggal;
            _jenisTiket = jenisTiket;
            _jumlah = jumlah;
            _totalBayar = totalBayar;
            _status = status;

            LoadDetailData();
        }

        public DetailTransaksiWy(UserModel user) : this()
        {
            _currentUser = user;
        }

        private void LoadDetailData()
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbNama.Text = _currentUser.Nama ?? "Tidak tersedia";
            tbJumlah.Text = _jumlah.ToString();
            tbTanggal.Text = _tanggal;
            tbJenisTiket.Text = _jenisTiket;
            tbHargaTiket.Text = _totalBayar;
            tbHargabayar.Text = _totalBayar;
            tbMetodeBayar.Text = "Transfer Bank";
            tbStatus.Text = _status;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Transaksi transaksi = new Transaksi(_currentUser);
                transaksi.Show();
                this.Hide();
            }
        }

        private void btnberanda_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Beranda beranda = new Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Tiket tiket = new Tiket(_currentUser);
                tiket.Show();
                this.Hide();
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Transaksi transaksi = new Transaksi(_currentUser);
                transaksi.Show();
                this.Hide();
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Profil profil = new Profil(_currentUser);
                profil.Show();
                this.Hide();
            }
        }
    }
}