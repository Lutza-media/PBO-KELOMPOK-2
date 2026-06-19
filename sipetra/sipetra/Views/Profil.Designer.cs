namespace sipetra.Views
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            pictureBox1 = new PictureBox();
            tbEditProfil = new Button();
            bntProfil = new Button();
            btnTransaksi = new Button();
            btnTiket = new Button();
            btnBeranda = new Button();
            btnEmail = new TextBox();
            btnNamaLengkap = new TextBox();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbEditProfil
            // 
            tbEditProfil.BackgroundImage = (Image)resources.GetObject("tbEditProfil.BackgroundImage");
            tbEditProfil.Location = new Point(695, 862);
            tbEditProfil.Name = "tbEditProfil";
            tbEditProfil.Size = new Size(211, 51);
            tbEditProfil.TabIndex = 16;
            tbEditProfil.UseVisualStyleBackColor = true;
            tbEditProfil.Click += tbEditProfil_Click;
            // 
            // bntProfil
            // 
            bntProfil.BackgroundImage = (Image)resources.GetObject("bntProfil.BackgroundImage");
            bntProfil.Location = new Point(48, 633);
            bntProfil.Name = "bntProfil";
            bntProfil.Size = new Size(319, 59);
            bntProfil.TabIndex = 15;
            bntProfil.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(48, 546);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 14;
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnTiket
            // 
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(48, 454);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 13;
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
            btnBeranda.Location = new Point(48, 364);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(319, 59);
            btnBeranda.TabIndex = 12;
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnEmail
            // 
            btnEmail.BackColor = Color.White;
            btnEmail.BorderStyle = BorderStyle.FixedSingle;
            btnEmail.Location = new Point(833, 423);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(273, 31);
            btnEmail.TabIndex = 35;
            // 
            // btnNamaLengkap
            // 
            btnNamaLengkap.BackColor = Color.White;
            btnNamaLengkap.BorderStyle = BorderStyle.FixedSingle;
            btnNamaLengkap.Location = new Point(833, 315);
            btnNamaLengkap.Name = "btnNamaLengkap";
            btnNamaLengkap.Size = new Size(273, 31);
            btnNamaLengkap.TabIndex = 34;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 977);
            Controls.Add(btnEmail);
            Controls.Add(btnNamaLengkap);
            Controls.Add(tbEditProfil);
            Controls.Add(bntProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnBeranda);
            Controls.Add(pictureBox1);
            Name = "Profil";
            Text = "V_Ptrofil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private PictureBox pictureBox1;
        private Button tbEditProfil;
        private Button bntProfil;
        private Button btnTransaksi;
        private Button btnTiket;
        private Button btnBeranda;
        private TextBox btnEmail;
        private TextBox btnNamaLengkap;
    }
}