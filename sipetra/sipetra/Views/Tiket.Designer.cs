using sipetra.Views;

namespace sipetra
{
    partial class Tiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiket));
            btnBeranda = new Button();
            btnTiket = new Button();
            btnTransaksi = new Button();
            btnProfil = new Button();
            btnPesanTiketWeekday = new Button();
            btnPesanTiketWeekend = new Button();
            SuspendLayout();
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
            btnBeranda.TabIndex = 1;
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnTiket
            // 
            btnTiket.BackgroundImage = (Image)resources.GetObject("btnTiket.BackgroundImage");
            btnTiket.FlatAppearance.BorderColor = Color.White;
            btnTiket.FlatAppearance.BorderSize = 0;
            btnTiket.Location = new Point(46, 453);
            btnTiket.Name = "btnTiket";
            btnTiket.Size = new Size(319, 59);
            btnTiket.TabIndex = 2;
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
            btnTransaksi.TabIndex = 3;
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
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
            btnProfil.TabIndex = 4;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnPesanTiketWeekday
            // 
            btnPesanTiketWeekday.BackColor = SystemColors.ButtonHighlight;
            btnPesanTiketWeekday.BackgroundImage = (Image)resources.GetObject("btnPesanTiketWeekday.BackgroundImage");
            btnPesanTiketWeekday.FlatAppearance.BorderSize = 0;
            btnPesanTiketWeekday.FlatStyle = FlatStyle.Flat;
            btnPesanTiketWeekday.ForeColor = SystemColors.Control;
            btnPesanTiketWeekday.Location = new Point(1196, 218);
            btnPesanTiketWeekday.Name = "btnPesanTiketWeekday";
            btnPesanTiketWeekday.Size = new Size(158, 44);
            btnPesanTiketWeekday.TabIndex = 6;
            btnPesanTiketWeekday.UseVisualStyleBackColor = false;
            btnPesanTiketWeekday.Click += btnPesanTiket1_Click;

            // 
            // btnPesanTiketWeekend
            // 
            btnPesanTiketWeekend.BackColor = SystemColors.ButtonHighlight;
            btnPesanTiketWeekend.BackgroundImage = (Image)resources.GetObject("btnPesanTiketWeekend.BackgroundImage");
            btnPesanTiketWeekend.FlatAppearance.BorderSize = 0;
            btnPesanTiketWeekend.FlatStyle = FlatStyle.Flat;
            btnPesanTiketWeekend.ForeColor = SystemColors.Control;
            btnPesanTiketWeekend.Location = new Point(1196, 486);
            btnPesanTiketWeekend.Name = "btnPesanTiketWeekend";
            btnPesanTiketWeekend.Size = new Size(158, 44);
            btnPesanTiketWeekend.TabIndex = 7;
            btnPesanTiketWeekend.UseVisualStyleBackColor = false;
            btnPesanTiketWeekend.Click += btnPesanTiketWeekend_Click;
            // 
            // Tiket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1495, 978);
            Controls.Add(btnPesanTiketWeekend);
            Controls.Add(btnPesanTiketWeekday);
            Controls.Add(btnProfil);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTiket);
            Controls.Add(btnBeranda);
            Name = "Tiket";
            Text = "Tiket";
            Load += Tiket_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBeranda;
        private Button btnTiket;
        private Button btnTransaksi;
        private Button btnProfil;
        private Button btnPesanTiketWeekday;
        private Button btnPesanTiketWeekend;
    }
}