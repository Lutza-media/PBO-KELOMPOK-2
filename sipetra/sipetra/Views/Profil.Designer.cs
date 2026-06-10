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
            button1 = new Button();
            btnTransaksi = new Button();
            btnTiket = new Button();
            bntProfil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1533, 1038);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(46, 363);
            button1.Name = "button1";
            button1.Size = new Size(319, 59);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
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
            btnTransaksi.TabIndex = 4;
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
            btnTiket.Location = new Point(46, 453);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 6;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            // 
            // bntProfil
            // 
            bntProfil.BackgroundImage = (Image)resources.GetObject("bntProfil.BackgroundImage");
            bntProfil.Location = new Point(46, 632);
            bntProfil.Name = "bntProfil";
            bntProfil.Size = new Size(319, 59);
            bntProfil.TabIndex = 4;
            bntProfil.UseVisualStyleBackColor = true;
            bntProfil.Click += bntProfil_Click;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 977);
            Controls.Add(bntProfil);
            Controls.Add(btnTiket);
            Controls.Add(btnTransaksi);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button btnTransaksi;
        private Button btnTiket;
        private Button bntProfil;
    }
}