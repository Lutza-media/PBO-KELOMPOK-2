namespace sipetra.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            tbTiket = new TextBox();
            tbPendapatan = new TextBox();
            tbPengguna = new TextBox();
            dataGridViewTiket = new DataGridView();
            tbPencarian = new TextBox();
            btnRefresh = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();
            btnTiket = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiket).BeginInit();
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbTiket
            // 
            tbTiket.BackColor = Color.White;
            tbTiket.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tbTiket.ForeColor = Color.FromArgb(41, 128, 185);
            tbTiket.Location = new Point(1284, 178);
            tbTiket.Margin = new Padding(4);
            tbTiket.Name = "tbTiket";
            tbTiket.ReadOnly = true;
            tbTiket.Size = new Size(155, 45);
            tbTiket.TabIndex = 10;
            tbTiket.Text = "0";
            tbTiket.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPendapatan
            // 
            tbPendapatan.BackColor = Color.White;
            tbPendapatan.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tbPendapatan.ForeColor = Color.FromArgb(46, 204, 113);
            tbPendapatan.Location = new Point(921, 178);
            tbPendapatan.Margin = new Padding(4);
            tbPendapatan.Name = "tbPendapatan";
            tbPendapatan.ReadOnly = true;
            tbPendapatan.Size = new Size(176, 45);
            tbPendapatan.TabIndex = 12;
            tbPendapatan.Text = "Rp 0";
            tbPendapatan.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPengguna
            // 
            tbPengguna.BackColor = Color.White;
            tbPengguna.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tbPengguna.ForeColor = Color.FromArgb(155, 89, 182);
            tbPengguna.Location = new Point(561, 178);
            tbPengguna.Margin = new Padding(4);
            tbPengguna.Name = "tbPengguna";
            tbPengguna.ReadOnly = true;
            tbPengguna.Size = new Size(120, 45);
            tbPengguna.TabIndex = 13;
            tbPengguna.Text = "0";
            tbPengguna.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewTiket
            // 
            dataGridViewTiket.AllowUserToAddRows = false;
            dataGridViewTiket.AllowUserToDeleteRows = false;
            dataGridViewTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTiket.BackgroundColor = Color.White;
            dataGridViewTiket.BorderStyle = BorderStyle.None;
            dataGridViewTiket.ColumnHeadersHeight = 34;
            dataGridViewTiket.Location = new Point(431, 388);
            dataGridViewTiket.Margin = new Padding(4);
            dataGridViewTiket.MultiSelect = false;
            dataGridViewTiket.Name = "dataGridViewTiket";
            dataGridViewTiket.ReadOnly = true;
            dataGridViewTiket.RowHeadersVisible = false;
            dataGridViewTiket.RowHeadersWidth = 62;
            dataGridViewTiket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiket.Size = new Size(1075, 500);
            dataGridViewTiket.TabIndex = 11;
            dataGridViewTiket.CellClick += dataGridViewTiket_CellClick;
            dataGridViewTiket.CellFormatting += DataGridViewTiket_CellFormatting;
            // 
            // tbPencarian
            // 
            tbPencarian.Font = new Font("Segoe UI", 11F);
            tbPencarian.ForeColor = Color.Gray;
            tbPencarian.Location = new Point(520, 312);
            tbPencarian.Margin = new Padding(4);
            tbPencarian.Name = "tbPencarian";
            tbPencarian.Size = new Size(271, 37);
            tbPencarian.TabIndex = 14;
            tbPencarian.Text = "Cari tiket...";
            tbPencarian.TextChanged += tbPencarian_TextChanged;
            tbPencarian.Enter += tbPencarian_Enter;
            tbPencarian.Leave += tbPencarian_Leave;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(872, 306);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(134, 50);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.PaleGoldenrod;
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(38, 471);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 38;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(38, 640);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(319, 59);
            btnProfil.TabIndex = 39;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnTiket
            // 
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(38, 551);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 40;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            btnTiket.Click += btnTiket_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.PaleGoldenrod;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(38, 388);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(319, 59);
            btnDashboard.TabIndex = 41;
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(38, 905);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 50);
            btnLogout.TabIndex = 20;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 1015);
            Controls.Add(btnDashboard);
            Controls.Add(btnTiket);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(tbTiket);
            Controls.Add(tbPendapatan);
            Controls.Add(tbPengguna);
            Controls.Add(dataGridViewTiket);
            Controls.Add(tbPencarian);
            Controls.Add(btnRefresh);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Admin";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private TextBox tbTiket;
        private TextBox tbPendapatan;
        private TextBox tbPengguna;
        private DataGridView dataGridViewTiket;
        private TextBox tbPencarian;
        private Button btnRefresh;
        private Button btnTransaksi;
        private Button btnProfil;
        private Button btnTiket;
        private Button btnDashboard;
        private Button button1;
        private Button btnLogout;
    }
}