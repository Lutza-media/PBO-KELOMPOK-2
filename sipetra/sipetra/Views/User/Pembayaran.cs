using System;
using System.Windows.Forms;
using sipetra.Models;


namespace sipetra.Views.User
{
    public partial class Pembayaran : Form
    {
        private UserModel _currentUser;  // ✅ UserModel (bukan Models.UserModels)
        private int _jumlahTiket;
        private string _jenisTiket;
        private int _hargaSatuan;

        public Pembayaran()
        {
            InitializeComponent();
        }

        public Pembayaran(UserModel user, string jenisTiket, int jumlah, int hargaSatuan) : this()  // ✅ UserModel
        {
            _currentUser = user;
            _jenisTiket = jenisTiket;
            _jumlahTiket = jumlah;
            _hargaSatuan = hargaSatuan;
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            tbJenisTiket.Text = _jenisTiket;
            tbJumlahTiket.Text = _jumlahTiket.ToString();
            tbHargaSatuan.Text = $"Rp {_hargaSatuan:N0}";

            int total = _jumlahTiket * _hargaSatuan;
            btTotalHarga.Text = $"Rp {total:N0}";
        }

        private void btnKonfirmasiPembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentUser == null)
                {
                    MessageBox.Show("User tidak ditemukan! Silakan login kembali.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(_jenisTiket) || _jumlahTiket <= 0 || _hargaSatuan <= 0)
                {
                    MessageBox.Show("Data tiket tidak valid! Silakan pesan ulang.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                int totalBayar = _jumlahTiket * _hargaSatuan;
                DialogResult result = MessageBox.Show(
                    $"Konfirmasi Pembayaran\n\n" +
                    $"Jenis Tiket : {_jenisTiket}\n" +
                    $"Jumlah      : {_jumlahTiket} tiket\n" +
                    $"Total Bayar : Rp {totalBayar:N0}\n\n" +
                    $"Lanjutkan pembayaran?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                TransaksiModel transaksi = new TransaksiModel(
                    _currentUser.Id,
                    _jenisTiket,
                    _jumlahTiket,
                    totalBayar
                );

                bool berhasil = transaksi.Save();

                if (berhasil)
                {
                    MessageBox.Show(
                        $"Pembayaran BERHASIL!\n\n" +
                        $"Jenis Tiket : {_jenisTiket}\n" +
                        $"Jumlah      : {_jumlahTiket} tiket\n" +
                        $"Total Bayar : Rp {totalBayar:N0}\n\n" +
                        $"Terima kasih telah memesan tiket di Dragon Pick!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Transaksi formTransaksi = new Transaksi(_currentUser);
                    formTransaksi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Gagal menyimpan transaksi!\n\n" +
                        "Silakan coba lagi atau hubungi customer service.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Terjadi kesalahan:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(_currentUser);  // ✅ Langsung pakai Tiket (sudah ada using)
            tiket.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser);  // ✅ Langsung pakai Beranda
            beranda.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket(_currentUser);  // ✅ Langsung pakai Tiket
            tiket.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(_currentUser);
            transaksi.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
            this.Hide();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}