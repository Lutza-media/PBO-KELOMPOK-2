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
        }

        private void Pemesanan_Tiket_Load(object sender, EventArgs e)
        {

        }

    }
}
