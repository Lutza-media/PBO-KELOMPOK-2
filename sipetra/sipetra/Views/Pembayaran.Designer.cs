namespace sipetra.Views
{
    partial class Pembayaran
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnberanda = new Button();
            btnTiket = new Button();
            btnProfil = new Button();
            btnTransaksi = new Button();
            tbJenisTiket = new TextBox();
            tbHargaSatuan = new TextBox();
            btTotalHarga = new TextBox();
            tbJumlahTiket = new TextBox();
            btnKonfirmasiPembayaran = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1512, 982);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(504, 38);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 70);
            btnBack.TabIndex = 15;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnberanda
            // 
            btnberanda.BackgroundImage = (Image)resources.GetObject("btnberanda.BackgroundImage");
            btnberanda.FlatAppearance.BorderColor = Color.White;
            btnberanda.FlatAppearance.BorderSize = 0;
            btnberanda.FlatStyle = FlatStyle.Flat;
            btnberanda.Location = new Point(46, 363);
            btnberanda.Name = "btnberanda";
            btnberanda.Size = new Size(319, 59);
            btnberanda.TabIndex = 16;
            btnberanda.UseVisualStyleBackColor = true;
            btnberanda.Click += btnBeranda_Click;
            // 
            // btnTiket
            // 
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.White;
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.Location = new Point(46, 453);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 17;
            btnTiket.UseVisualStyleBackColor = true;
            btnTiket.Click += btnTiket_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(46, 635);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(319, 59);
            btnProfil.TabIndex = 19;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(46, 545);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 20;
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // tbJenisTiket
            // 
            tbJenisTiket.BackColor = Color.White;
            tbJenisTiket.BorderStyle = BorderStyle.None;
            tbJenisTiket.Location = new Point(694, 228);
            tbJenisTiket.Name = "tbJenisTiket";
            tbJenisTiket.ReadOnly = true;
            tbJenisTiket.Size = new Size(218, 24);
            tbJenisTiket.TabIndex = 24;
            // 
            // tbHargaSatuan
            // 
            tbHargaSatuan.BackColor = Color.White;
            tbHargaSatuan.BorderStyle = BorderStyle.None;
            tbHargaSatuan.Location = new Point(694, 324);
            tbHargaSatuan.Name = "tbHargaSatuan";
            tbHargaSatuan.ReadOnly = true;
            tbHargaSatuan.Size = new Size(218, 24);
            tbHargaSatuan.TabIndex = 25;
            // 
            // btTotalHarga
            // 
            btTotalHarga.BackColor = Color.White;
            btTotalHarga.BorderStyle = BorderStyle.None;
            btTotalHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btTotalHarga.ForeColor = Color.Green;
            btTotalHarga.Location = new Point(656, 427);
            btTotalHarga.Name = "btTotalHarga";
            btTotalHarga.ReadOnly = true;
            btTotalHarga.Size = new Size(218, 32);
            btTotalHarga.TabIndex = 26;
            // 
            // tbJumlahTiket
            // 
            tbJumlahTiket.BackColor = Color.White;
            tbJumlahTiket.BorderStyle = BorderStyle.None;
            tbJumlahTiket.Location = new Point(694, 276);
            tbJumlahTiket.Name = "tbJumlahTiket";
            tbJumlahTiket.ReadOnly = true;
            tbJumlahTiket.Size = new Size(218, 24);
            tbJumlahTiket.TabIndex = 27;
            // 
            // btnKonfirmasiPembayaran
            // 
            btnKonfirmasiPembayaran.BackColor = SystemColors.ButtonHighlight;
            btnKonfirmasiPembayaran.BackgroundImage = (Image)resources.GetObject("btnKonfirmasiPembayaran.BackgroundImage");
            btnKonfirmasiPembayaran.FlatAppearance.BorderSize = 0;
            btnKonfirmasiPembayaran.FlatStyle = FlatStyle.Flat;
            btnKonfirmasiPembayaran.Location = new Point(1248, 873);
            btnKonfirmasiPembayaran.Name = "btnKonfirmasiPembayaran";
            btnKonfirmasiPembayaran.Size = new Size(158, 44);
            btnKonfirmasiPembayaran.TabIndex = 28;
            btnKonfirmasiPembayaran.UseVisualStyleBackColor = false;
            btnKonfirmasiPembayaran.Click += btnKonfirmasiPembayaran_Click;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 973);
            Controls.Add(btnKonfirmasiPembayaran);
            Controls.Add(tbJumlahTiket);
            Controls.Add(btTotalHarga);
            Controls.Add(tbHargaSatuan);
            Controls.Add(tbJenisTiket);
            Controls.Add(btnTransaksi);
            Controls.Add(btnProfil);
            Controls.Add(btnTiket);
            Controls.Add(btnberanda);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Name = "Pembayaran";
            Text = "Pembayaran";
            Load += Pembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private PictureBox pictureBox1;
        private Button btnBack;
        private Button btnberanda;
        private Button btnTiket;
        private Button btnProfil;
        private Button btnTransaksi;
        private TextBox tbJenisTiket;
        private TextBox tbHargaSatuan;
        private TextBox btTotalHarga;
        private TextBox tbJumlahTiket;
        private Button btnKonfirmasiPembayaran;
    }
}