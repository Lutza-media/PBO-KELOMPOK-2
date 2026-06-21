namespace sipetra.Views.User
{
    partial class DetailTransaksiWd
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailTransaksiWd));
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnberanda = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();
            btnTiket = new Button();
            pictureBox2 = new PictureBox();
            tbHargaTiket = new Label();
            tbHargabayar = new Label();
            tbJenisTiket = new Label();
            tbJumlah = new Label();
            tbNama = new Label();
            tbMetodeBayar = new Label();
            tbStatus = new Label();
            tbTanggal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(478, 70);
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
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.PaleGoldenrod;
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(46, 545);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 17;
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
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
            btnProfil.TabIndex = 18;
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnTiket
            // 
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(46, 453);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 19;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1503, 982);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // tbHargaTiket
            // 
            tbHargaTiket.BackColor = Color.Transparent;
            tbHargaTiket.Location = new Point(1089, 583);
            tbHargaTiket.Name = "tbHargaTiket";
            tbHargaTiket.AutoSize = false;
            tbHargaTiket.Size = new Size(218, 24);
            tbHargaTiket.TabIndex = 25;
            // 
            // tbHargabayar
            // 
            tbHargabayar.BackColor = Color.Transparent;
            tbHargabayar.Location = new Point(1106, 617);
            tbHargabayar.Name = "tbHargabayar";
            tbHargabayar.AutoSize = false;
            tbHargabayar.Size = new Size(218, 24);
            tbHargabayar.TabIndex = 26;
            // 
            // tbJenisTiket
            // 
            tbJenisTiket.BackColor = Color.Transparent;
            tbJenisTiket.Location = new Point(1085, 549);
            tbJenisTiket.Name = "tbJenisTiket";
            tbJenisTiket.AutoSize = false;
            tbJenisTiket.Size = new Size(218, 24);
            tbJenisTiket.TabIndex = 27;
            // 
            // tbJumlah
            // 
            tbJumlah.BackColor = Color.Transparent;
            tbJumlah.Location = new Point(1062, 481);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.AutoSize = false;
            tbJumlah.Size = new Size(218, 24);
            tbJumlah.TabIndex = 28;
            // 
            // tbNama
            // 
            tbNama.BackColor = Color.Transparent;
            tbNama.Location = new Point(1048, 447);
            tbNama.Name = "tbNama";
            tbNama.AutoSize = false;
            tbNama.Size = new Size(218, 24);
            tbNama.TabIndex = 29;
            // 
            // tbMetodeBayar
            // 
            tbMetodeBayar.BackColor = Color.Transparent;
            tbMetodeBayar.Location = new Point(1150, 652);
            tbMetodeBayar.Name = "tbMetodeBayar";
            tbMetodeBayar.AutoSize = false;
            tbMetodeBayar.Size = new Size(218, 24);
            tbMetodeBayar.TabIndex = 30;
            // 
            // tbStatus
            // 
            tbStatus.BackColor = Color.Transparent;
            tbStatus.Location = new Point(1114, 685);
            tbStatus.Name = "tbStatus";
            tbStatus.AutoSize = false;
            tbStatus.Size = new Size(218, 24);
            tbStatus.TabIndex = 31;
            // 
            // tbTanggal
            // 
            tbTanggal.BackColor = Color.Transparent;
            tbTanggal.Location = new Point(1059, 514);
            tbTanggal.Name = "tbTanggal";
            tbTanggal.AutoSize = false;
            tbTanggal.Size = new Size(218, 24);
            tbTanggal.TabIndex = 32;
            // 
            // Label-label di atas dijadikan child dari pictureBox2 (bukan Form)
            // supaya transparansinya tembus ke gambar, bukan ke warna Form
            // 
            pictureBox2.Controls.Add(tbHargaTiket);
            pictureBox2.Controls.Add(tbHargabayar);
            pictureBox2.Controls.Add(tbJenisTiket);
            pictureBox2.Controls.Add(tbJumlah);
            pictureBox2.Controls.Add(tbNama);
            pictureBox2.Controls.Add(tbMetodeBayar);
            pictureBox2.Controls.Add(tbStatus);
            pictureBox2.Controls.Add(tbTanggal);
            // 
            // DetailTransaksiWd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 1027);
            Controls.Add(btnTiket);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnberanda);
            Controls.Add(btnBack);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DetailTransaksiWd";
            Text = "DetailTransaksi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBack;
        private Button btnberanda;
        private Button btnTransaksi;
        private Button btnProfil;
        private Button btnTiket;
        private PictureBox pictureBox2;
        private Label tbHargaTiket;
        private Label tbHargabayar;
        private Label tbJenisTiket;
        private Label tbJumlah;
        private Label tbNama;
        private Label tbMetodeBayar;
        private Label tbStatus;
        private Label tbTanggal;
    }
}