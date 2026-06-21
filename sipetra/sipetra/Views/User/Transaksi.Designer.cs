namespace sipetra.Views
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            pictureBox1 = new PictureBox();
            btnDataTransaksi = new Button();
            btnProfil = new Button();
            btnTransaksi = new Button();
            btnTiket = new Button();
            btnBeranda = new Button();
            btnRiwayatTransaksi = new Button();
            dataGridViewTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaksi).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1506, 985);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDataTransaksi
            // 
            btnDataTransaksi.BackColor = SystemColors.ButtonHighlight;
            btnDataTransaksi.BackgroundImage = (Image)resources.GetObject("btnDataTransaksi.BackgroundImage");
            btnDataTransaksi.FlatAppearance.BorderSize = 0;
            btnDataTransaksi.FlatStyle = FlatStyle.Flat;
            btnDataTransaksi.ForeColor = SystemColors.Control;
            btnDataTransaksi.Location = new Point(443, 173);
            btnDataTransaksi.Margin = new Padding(2);
            btnDataTransaksi.Name = "btnDataTransaksi";
            btnDataTransaksi.Size = new Size(180, 82);
            btnDataTransaksi.TabIndex = 47;
            btnDataTransaksi.UseVisualStyleBackColor = false;
            btnDataTransaksi.Click += button1_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(30, 676);
            btnProfil.Margin = new Padding(2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(319, 59);
            btnProfil.TabIndex = 46;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.PaleGoldenrod;
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(30, 572);
            btnTransaksi.Margin = new Padding(2);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 45;
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnTiket
            // 
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(30, 477);
            btnTiket.Margin = new Padding(2);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 44;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            btnTiket.Click += btnTiket_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackgroundImage = (Image)resources.GetObject("btnBeranda.BackgroundImage");
            btnBeranda.FlatAppearance.BorderColor = Color.White;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Location = new Point(30, 383);
            btnBeranda.Margin = new Padding(2);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(319, 59);
            btnBeranda.TabIndex = 43;
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = SystemColors.ButtonHighlight;
            btnRiwayatTransaksi.BackgroundImage = (Image)resources.GetObject("btnRiwayatTransaksi.BackgroundImage");
            btnRiwayatTransaksi.FlatAppearance.BorderSize = 0;
            btnRiwayatTransaksi.FlatStyle = FlatStyle.Flat;
            btnRiwayatTransaksi.ForeColor = SystemColors.Control;
            btnRiwayatTransaksi.Location = new Point(627, 173);
            btnRiwayatTransaksi.Margin = new Padding(2);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(229, 82);
            btnRiwayatTransaksi.TabIndex = 48;
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // dataGridViewTransaksi
            // 
            dataGridViewTransaksi.AllowUserToAddRows = false;
            dataGridViewTransaksi.AllowUserToDeleteRows = false;
            dataGridViewTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransaksi.BackgroundColor = Color.White;
            dataGridViewTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaksi.Location = new Point(443, 287);
            dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            dataGridViewTransaksi.ReadOnly = true;
            dataGridViewTransaksi.RowHeadersWidth = 62;
            dataGridViewTransaksi.Size = new Size(1017, 400);
            dataGridViewTransaksi.TabIndex = 49;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 978);
            Controls.Add(dataGridViewTransaksi);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnDataTransaksi);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnBeranda);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Transaksi";
            Text = "Data Transaksi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaksi).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
        private Button btnDataTransaksi;
        private Button btnProfil;
        private Button btnTransaksi;
        private Button btnTiket;
        private Button btnBeranda;
        private Button btnRiwayatTransaksi;
        private DataGridView dataGridViewTransaksi;
    }
}