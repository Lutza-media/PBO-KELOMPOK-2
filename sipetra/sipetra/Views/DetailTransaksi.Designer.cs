namespace sipetra.Views
{
    partial class DetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailTransaksi));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnBack = new Button();
            btnberanda = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();
            btnTiket = new Button();
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1581, 1028);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(497, 35);
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
            // DetailTransaksi
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
            Name = "DetailTransaksi";
            Text = "DetailTransaksi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnBack;
        private Button btnberanda;
        private Button btnTransaksi;
        private Button btnProfil;
        private Button btnTiket;
    }
}