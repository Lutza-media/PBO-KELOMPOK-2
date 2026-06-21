namespace sipetra.Views
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));

            // PictureBox Background
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            // TextBox Nama Lengkap
            tbNamaLengkap = new TextBox();

            // TextBox Email
            tbEmail = new TextBox();

            // Tombol Edit Profil
            btnEditProfil = new Button();

            // Tombol Navigasi
            btnBeranda = new Button();
            btnTiket = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();

            SuspendLayout();

            // ============================================================
            // pictureBox1 (Background)
            // ============================================================
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1512, 982);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // ============================================================
            // txtNamaLengkap (TextBox Nama)
            // ============================================================
            tbNamaLengkap.BackColor = Color.White;
            tbNamaLengkap.BorderStyle = BorderStyle.FixedSingle;
            tbNamaLengkap.Location = new Point(833, 315);
            tbNamaLengkap.Name = "txtNamaLengkap";
            tbNamaLengkap.ReadOnly = true;
            tbNamaLengkap.Size = new Size(273, 31);
            tbNamaLengkap.TabIndex = 0;

            // ============================================================
            // txtEmail (TextBox Email)
            // ============================================================
            tbEmail.BackColor = Color.White;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(833, 423);
            tbEmail.Name = "txtEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(273, 31);
            tbEmail.TabIndex = 1;

            // ============================================================
            // btnEditProfil (Tombol Edit Profil)
            // ============================================================
            btnEditProfil.BackgroundImage = (Image)resources.GetObject("btnEditProfil.BackgroundImage");
            btnEditProfil.Location = new Point(695, 862);
            btnEditProfil.Name = "btnEditProfil";
            btnEditProfil.Size = new Size(211, 51);
            btnEditProfil.TabIndex = 2;
            btnEditProfil.UseVisualStyleBackColor = true;
            btnEditProfil.Click += new EventHandler(btnEditProfil_Click);

            // ============================================================
            // btnBeranda (Tombol Navigasi)
            // ============================================================
            btnBeranda.BackgroundImage = (Image)resources.GetObject("btnBeranda.BackgroundImage");
            btnBeranda.FlatAppearance.BorderColor = Color.White;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Location = new Point(48, 364);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(319, 59);
            btnBeranda.TabIndex = 3;
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += new EventHandler(btnBeranda_Click);

            // ============================================================
            // btnTiket (Tombol Navigasi)
            // ============================================================
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(48, 454);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 4;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            btnTiket.Click += new EventHandler(btnTiket_Click);

            // ============================================================
            // btnTransaksi (Tombol Navigasi)
            // ============================================================
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(48, 546);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 5;
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += new EventHandler(btnTransaksi_Click);

            // ============================================================
            // btnProfil (Tombol Navigasi)
            // ============================================================
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.Location = new Point(48, 633);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(319, 59);
            btnProfil.TabIndex = 6;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += new EventHandler(btnProfil_Click);

            // ============================================================
            // Profil
            // ============================================================
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 977);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnBeranda);
            Controls.Add(btnEditProfil);
            Controls.Add(tbEmail);
            Controls.Add(tbNamaLengkap);
            Controls.Add(pictureBox1);
            Name = "Profil";
            Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ============================================================
        // DEKLARASI KOMPONEN
        // ============================================================
        private PictureBox pictureBox1;
        private TextBox tbNamaLengkap;  // ← Nama diubah
        private TextBox tbEmail;        // ← Nama diubah
        private Button btnEditProfil;    // ← Nama diubah dari tbEditProfil
        private Button btnBeranda;
        private Button btnTiket;
        private Button btnTransaksi;
        private Button btnProfil;
    }
}