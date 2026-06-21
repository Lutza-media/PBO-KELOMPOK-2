namespace sipetra.Views.User
{
    partial class Pesanan2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesanan2));
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnPembayaran = new Button();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            btnberanda = new Button();
            btnTiket = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1512, 982);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new EventHandler(pictureBox1_Click);
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(547, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 70);
            btnBack.TabIndex = 15;
            btnBack.UseVisualStyleBackColor = false;
            // TAMBAHKAN event handler:
            btnBack.Click += new EventHandler(btnBack_Click);
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackColor = SystemColors.ButtonHighlight;
            btnPembayaran.BackgroundImage = (Image)resources.GetObject("btnPembayaran.BackgroundImage");
            btnPembayaran.FlatAppearance.BorderSize = 0;
            btnPembayaran.FlatStyle = FlatStyle.Flat;
            btnPembayaran.Location = new Point(1228, 591);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(158, 44);
            btnPembayaran.TabIndex = 16;
            btnPembayaran.UseVisualStyleBackColor = false;
            // TAMBAHKAN event handler:
            btnPembayaran.Click += new EventHandler(btnPembayaran_Click);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(805, 526);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(805, 604);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 18;
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
            btnberanda.TabIndex = 19;
            btnberanda.UseVisualStyleBackColor = true;
            // TAMBAHKAN event handler:
            btnberanda.Click += new EventHandler(btnBeranda_Click);
            // 
            // btnTiket
            // 
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.White;
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.Location = new Point(46, 453);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 20;
            btnTiket.UseVisualStyleBackColor = true;
            // TAMBAHKAN event handler:
            btnTiket.Click += new EventHandler(btnTiket_Click);
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
            btnTransaksi.TabIndex = 21;
            btnTransaksi.UseVisualStyleBackColor = true;
            // TAMBAHKAN event handler:
            btnTransaksi.Click += new EventHandler(btnTransaksi_Click);
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
            btnProfil.TabIndex = 22;
            btnProfil.UseVisualStyleBackColor = true;
            // TAMBAHKAN event handler:
            btnProfil.Click += new EventHandler(btnProfil_Click);
            // 
            // Pesanan2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 978);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnberanda);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(btnPembayaran);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Name = "Pesanan2";
            ShowInTaskbar = false;
            Text = "Pesanan2";
            Load += new EventHandler(Pesanan2_Load);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Button btnBack;
        private Button btnPembayaran;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private Button btnberanda;
        private Button btnTiket;
        private Button btnTransaksi;
        private Button btnProfil;
    }
}