using System.Drawing;
using System.Windows.Forms;

namespace sipetra.Views  // ✅ PASTIKAN NAMESPACE = sipetra.Views
{
    partial class Riwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat));
            pictureBox1 = new PictureBox();
            btnBeranda = new Button();
            btnProfil = new Button();
            btnTransaksi = new Button();
            btnTiket = new Button();
            btnDataTransaksi = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1503, 982);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBeranda
            // 
            btnBeranda.BackgroundImage = (Image)resources.GetObject("btnBeranda.BackgroundImage");
            btnBeranda.FlatAppearance.BorderColor = Color.White;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Location = new Point(46, 363);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(319, 59);
            btnBeranda.TabIndex = 17;
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
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
            btnProfil.Click += btnProfil_Click;  // ✅ PASTIKAN INI ADA
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
            btnTransaksi.TabIndex = 19;
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
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
            btnTiket.TabIndex = 20;
            btnTiket.TextAlign = ContentAlignment.MiddleLeft;
            btnTiket.UseVisualStyleBackColor = false;
            btnTiket.Click += btnTiket_Click;
            // 
            // btnDataTransaksi
            // 
            btnDataTransaksi.BackColor = SystemColors.ButtonHighlight;
            btnDataTransaksi.BackgroundImage = (Image)resources.GetObject("btnDataTransaksi.BackgroundImage");
            btnDataTransaksi.FlatAppearance.BorderSize = 0;
            btnDataTransaksi.FlatStyle = FlatStyle.Flat;
            btnDataTransaksi.ForeColor = SystemColors.Control;
            btnDataTransaksi.Location = new Point(445, 143);
            btnDataTransaksi.Margin = new Padding(2);
            btnDataTransaksi.Name = "btnDataTransaksi";
            btnDataTransaksi.Size = new Size(180, 82);
            btnDataTransaksi.TabIndex = 48;
            btnDataTransaksi.UseVisualStyleBackColor = false;
            btnDataTransaksi.Click += btnDataTransaksi_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(643, 143);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(223, 82);
            button1.TabIndex = 49;
            button1.UseVisualStyleBackColor = false;
            // button1.Click += button1_Click;  // ✅ TAMBAHKAN JIKA PERLU
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 978);
            Controls.Add(button1);
            Controls.Add(btnDataTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnTransaksi);
            Controls.Add(btnProfil);
            Controls.Add(btnBeranda);
            Controls.Add(pictureBox1);
            Name = "Riwayat";
            Text = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBeranda;
        private Button btnProfil;
        private Button btnTransaksi;
        private Button btnTiket;
        private Button btnDataTransaksi;
        private Button button1;
    }
}