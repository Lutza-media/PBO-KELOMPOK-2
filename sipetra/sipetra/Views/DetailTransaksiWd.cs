using System;
using System.Windows.Forms;
using sipetra.Models;

namespace sipetra.Views
{
    public partial class DetailTransaksiWd : Form
    {
        private User? _currentUser;
        private string _idTransaksi = "";
        private string _tanggal = "";
        private string _jenisTiket = "";
        private int _jumlah = 0;
        private string _totalBayar = "";
        private string _status = "";

        public DetailTransaksiWd()
        {
            InitializeComponent();
            pictureBox2.SendToBack();
        }

        // ============================================================
        // CONSTRUCTOR UTAMA - Dengan 7 parameter
        // ============================================================
        public DetailTransaksiWd(User user, string idTransaksi, string tanggal, string jenisTiket, int jumlah, string totalBayar, string status) : this()
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

        // ============================================================
        // CONSTRUCTOR OVERLOAD - Untuk kompatibilitas
        // ============================================================
        public DetailTransaksiWd(User user) : this()
        {
            _currentUser = user;
        }

        // ============================================================
        // LOAD DATA KE TEXTBOX
        // ============================================================
        private void LoadDetailData()
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Data user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Isi semua TextBox dengan data transaksi
            tbNama.Text = _currentUser.Nama ?? "Tidak tersedia";
            tbJumlah.Text = _jumlah.ToString();
            tbTanggal.Text = _tanggal;
            tbJenisTiket.Text = _jenisTiket;

            // Tampilkan harga
            tbHargaTiket.Text = _totalBayar;
            tbHargabayar.Text = _totalBayar;

            // Metode pembayaran default
            tbMetodeBayar.Text = "Transfer Bank";

            // Status pesanan
            tbStatus.Text = _status;
        }

        // ============================================================
        // NAVIGASI
        // ============================================================
        private void btnBack_Click(object? sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Transaksi transaksi = new Transaksi(_currentUser);
                transaksi.Show();
                this.Hide();
            }
        }

        private void btnberanda_Click(object? sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Beranda beranda = new Beranda(_currentUser);
                beranda.Show();
                this.Hide();
            }
        }

        private void btnTiket_Click(object? sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Tiket tiket = new Tiket(_currentUser);
                tiket.Show();
                this.Hide();
            }
        }

        private void btnTransaksi_Click(object? sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Transaksi transaksi = new Transaksi(_currentUser);
                transaksi.Show();
                this.Hide();
            }
        }

        private void btnProfil_Click(object? sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                Profil profil = new Profil(_currentUser);
                profil.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object? sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }
    }
}