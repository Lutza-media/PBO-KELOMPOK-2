namespace sipetra.Views.NewFolder
{
    partial class Pesanan1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesanan1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnPembayaran = new Button();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            btnBack = new Button();
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
            pictureBox1.Size = new Size(1513, 979);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
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
            btnPembayaran.TabIndex = 11;
            btnPembayaran.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(798, 529);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(798, 604);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 13;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(557, 40);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 70);
            btnBack.TabIndex = 14;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnTiket
            // 
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.White;
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.Location = new Point(46, 453);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 15;
            btnTiket.UseVisualStyleBackColor = true;
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
            btnTransaksi.TabIndex = 16;
            btnTransaksi.UseVisualStyleBackColor = true;
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
            btnProfil.TabIndex = 17;
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // Pesanan1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 970);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnBack);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(btnPembayaran);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Pesanan1";
            Text = "Pesanan1";
            Load += this.Pesanan1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button btnPembayaran;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private Button btnBack;
        private Button btnTiket;
        private Button btnTransaksi;
        private Button btnProfil;
    }
}