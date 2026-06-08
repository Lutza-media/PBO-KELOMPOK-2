namespace sipetra.Views
{
    partial class Pemesanan_Tiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pemesanan_Tiket));
            button1 = new Button();
            btnBack = new Button();
            picTiket = new PictureBox();
            label1 = new Label();
            lblNamaTiket = new Label();
            lblHargaTiket = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            btnPembayaran = new Button();
            ((System.ComponentModel.ISupportInitialize)picTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(513, 50);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 70);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // picTiket
            // 
            picTiket.BackColor = SystemColors.ButtonHighlight;
            picTiket.Location = new Point(547, 245);
            picTiket.Name = "picTiket";
            picTiket.Size = new Size(364, 244);
            picTiket.TabIndex = 2;
            picTiket.TabStop = false;
            //picTiket.Click += picTiket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // lblNamaTiket
            // 
            lblNamaTiket.AutoSize = true;
            lblNamaTiket.BackColor = SystemColors.ButtonHighlight;
            lblNamaTiket.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNamaTiket.Location = new Point(945, 245);
            lblNamaTiket.Name = "lblNamaTiket";
            lblNamaTiket.Size = new Size(0, 32);
            lblNamaTiket.TabIndex = 4;
            // 
            // lblHargaTiket
            // 
            lblHargaTiket.AutoSize = true;
            lblHargaTiket.BackColor = SystemColors.ButtonHighlight;
            lblHargaTiket.Font = new Font("Segoe UI", 9F);
            lblHargaTiket.Location = new Point(945, 311);
            lblHargaTiket.Name = "lblHargaTiket";
            lblHargaTiket.Size = new Size(0, 25);
            lblHargaTiket.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(798, 529);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(798, 604);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            btnPembayaran.TabIndex = 10;
            btnPembayaran.UseVisualStyleBackColor = false;
            // 
            // Pemesanan_Tiket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1511, 982);
            Controls.Add(btnPembayaran);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblHargaTiket);
            Controls.Add(lblNamaTiket);
            Controls.Add(label1);
            Controls.Add(picTiket);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Name = "Pemesanan_Tiket";
            Text = "Pemesanan_Tiket";
            Load += Pemesanan_Tiket_Load;
            ((System.ComponentModel.ISupportInitialize)picTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnBack;
        private PictureBox picTiket;
        private Label label1;
        private Label lblNamaTiket;
        private Label lblHargaTiket;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button btnPembayaran;
    }
}