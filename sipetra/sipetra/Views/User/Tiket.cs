using sipetra.Models;
using System.Windows.Forms;

namespace sipetra.Views.User
{
    public partial class Tiket : Form
    {
        private UserModel _currentUser;

        public Tiket()
        {
            InitializeComponent();
        }

        public Tiket(UserModel user) : this()
        {
            _currentUser = user;
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda(_currentUser);
            beranda.Show();
            this.Hide();
        }

        // ✅ TAMBAHKAN METHOD INI UNTUK btnTiket
        private void btnTiket_Click(object sender, EventArgs e)
        {
            // Refresh halaman atau scroll ke atas
            // Atau kosongkan saja
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_currentUser);
            profil.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi(_currentUser);
            transaksi.Show();
            this.Hide();
        }

        private void btnPesanTiketWeekday_Click(object sender, EventArgs e)
        {
            Pesanan1 pesanan = new Pesanan1(_currentUser);  // ✅ Langsung pakai Pesanan1
            pesanan.Show();
            this.Hide();
        }

        private void btnPesanTiketWeekend_Click(object sender, EventArgs e)
        {
            Pesanan2 pesanan = new Pesanan2(_currentUser);  // ✅ Langsung pakai Pesanan2
            pesanan.Show();
            this.Hide();
        }

        private void Tiket_Load(object sender, EventArgs e) { }

        private void Tiket_Load_1(object sender, EventArgs e) { }

        private void btnPesanTiket1_Click(object sender, EventArgs e)
        {
            btnPesanTiketWeekday_Click(sender, e);
        }
    }
}