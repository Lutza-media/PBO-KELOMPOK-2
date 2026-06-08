namespace sipetra.Views
{
    partial class Beranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda));
            button1 = new Button();
            btnTiket = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(46, 363);
            button1.Name = "button1";
            button1.Size = new Size(319, 59);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // btnTiket
            // 
            btnTiket.BackColor = Color.PaleGoldenrod;
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.FlatStyle = FlatStyle.Flat;
            btnTiket.Location = new Point(46, 455);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 4;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            btnTiket.Click += btnTiket_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.PaleGoldenrod;
            btnTransaksi.BackgroundImage = (Image)resources.GetObject("btnTransaksi.BackgroundImage");
            btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(46, 541);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(319, 59);
            btnTransaksi.TabIndex = 5;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.PaleGoldenrod;
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(46, 642);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(319, 59);
            btnProfil.TabIndex = 6;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // Beranda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1511, 1027);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(button1);
            Name = "Beranda";
            Text = "Beranda";
            Load += Beranda_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnTiket;
        private Button btnTransaksi;
        private Button btnProfil;
    }
}