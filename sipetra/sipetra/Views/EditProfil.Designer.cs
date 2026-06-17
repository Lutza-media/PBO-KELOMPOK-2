namespace sipetra.Views
{
    partial class EditProfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfil));
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnBeranda = new Button();
            btnTiket = new Button();
            btnTransaksi = new Button();
            btnNamaLengkap = new TextBox();
            btnEmailEdit = new TextBox();
            btnBatalEdit = new Button();
            btnSimpan = new Button();
            bntProfil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1512, 982);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(499, 44);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 70);
            btnBack.TabIndex = 20;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackgroundImage = (Image)resources.GetObject("btnBeranda.BackgroundImage");
            btnBeranda.FlatAppearance.BorderColor = Color.White;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Location = new Point(45, 362);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(319, 59);
            btnBeranda.TabIndex = 21;
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnTiket
            // 
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(45, 447);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 22;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            btnTiket.Click += btnTiket_Click_1;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.PaleGoldenrod;
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(45, 534);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 23;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnNamaLengkap
            // 
            btnNamaLengkap.BackColor = Color.WhiteSmoke;
            btnNamaLengkap.BorderStyle = BorderStyle.FixedSingle;
            btnNamaLengkap.Location = new Point(657, 475);
            btnNamaLengkap.Name = "btnNamaLengkap";
            btnNamaLengkap.Size = new Size(273, 31);
            btnNamaLengkap.TabIndex = 24;
            btnNamaLengkap.UseWaitCursor = true;
            btnNamaLengkap.TextChanged += tbNama_TextChanged;
            // 
            // btnEmailEdit
            // 
            btnEmailEdit.BorderStyle = BorderStyle.FixedSingle;
            btnEmailEdit.Location = new Point(657, 582);
            btnEmailEdit.Name = "btnEmailEdit";
            btnEmailEdit.Size = new Size(273, 31);
            btnEmailEdit.TabIndex = 25;
            // 
            // btnBatalEdit
            // 
            btnBatalEdit.BackColor = SystemColors.ButtonHighlight;
            btnBatalEdit.BackgroundImage = (Image)resources.GetObject("btnBatalEdit.BackgroundImage");
            btnBatalEdit.FlatAppearance.BorderSize = 0;
            btnBatalEdit.FlatStyle = FlatStyle.Flat;
            btnBatalEdit.Location = new Point(575, 854);
            btnBatalEdit.Name = "btnBatalEdit";
            btnBatalEdit.Size = new Size(200, 44);
            btnBatalEdit.TabIndex = 26;
            btnBatalEdit.UseVisualStyleBackColor = false;
            btnBatalEdit.Click += btnBatalEdit_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.ButtonHighlight;
            btnSimpan.BackgroundImage = (Image)resources.GetObject("btnSimpan.BackgroundImage");
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(833, 854);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(200, 44);
            btnSimpan.TabIndex = 27;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // bntProfil
            // 
            bntProfil.BackgroundImage = (Image)resources.GetObject("bntProfil.BackgroundImage");
            bntProfil.Location = new Point(45, 620);
            bntProfil.Name = "bntProfil";
            bntProfil.Size = new Size(319, 59);
            bntProfil.TabIndex = 28;
            bntProfil.UseVisualStyleBackColor = true;
            bntProfil.Click += bntProfil_Click;
            // 
            // EditProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 978);
            Controls.Add(bntProfil);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatalEdit);
            Controls.Add(btnEmailEdit);
            Controls.Add(btnNamaLengkap);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnBeranda);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Name = "EditProfil";
            Text = "EditProfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBack;
        private Button btnBeranda;
        private Button btnTiket;
        private Button btnTransaksi;
        private TextBox btnNamaLengkap;
        private TextBox btnEmailEdit;
        private Button btnBatalEdit;
        private Button btnSimpan;
        private Button bntProfil;
    }
}