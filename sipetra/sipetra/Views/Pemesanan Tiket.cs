using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sipetra.Views
{
    public partial class Pemesanan_Tiket : Form
    {
        public Pemesanan_Tiket(string namaTiket, string hargaTiket, Image fotoTiket)
        {
            InitializeComponent();

            lblNamaTiket.Text = namaTiket;
            lblHargaTiket.Text = hargaTiket;
            picTiket.Image = fotoTiket;

            btnPembayaran.Click += btnPembayaran_Click;
        }

        private void Pemesanan_Tiket_Load(object sender, EventArgs e)
        {

        }
        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            DateTime tanggal = dateTimePicker2.Value;
            int jumlah = (int)numericUpDown1.Value;

            MessageBox.Show(
                $"Tiket: {lblNamaTiket.Text}\n" +
                $"Tanggal: {tanggal:dd/MM/yyyy}\n" +
                $"Jumlah: {jumlah}",
                "Pemesanan Berhasil"
            );
        }




    }
}
