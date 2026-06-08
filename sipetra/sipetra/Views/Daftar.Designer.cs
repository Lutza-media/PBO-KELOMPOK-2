namespace sipetra.Views
{
    partial class Daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar));
            tbNama = new TextBox();
            tbEmail = new TextBox();
            tbKataSandi = new TextBox();
            btnDaftar = new Button();
            label1 = new Label();
            btnLogin = new Button();
            chkShow = new CheckBox();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Location = new Point(869, 436);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(518, 24);
            tbNama.TabIndex = 0;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Location = new Point(869, 592);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(518, 24);
            tbEmail.TabIndex = 1;
            // 
            // tbKataSandi
            // 
            tbKataSandi.BorderStyle = BorderStyle.None;
            tbKataSandi.Location = new Point(869, 742);
            tbKataSandi.Name = "tbKataSandi";
            tbKataSandi.Size = new Size(518, 24);
            tbKataSandi.TabIndex = 2;
            tbKataSandi.UseSystemPasswordChar = true;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = SystemColors.ButtonHighlight;
            btnDaftar.BackgroundImage = (Image)resources.GetObject("btnDaftar.BackgroundImage");
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Location = new Point(858, 832);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(559, 73);
            btnDaftar.TabIndex = 4;
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1006, 918);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 5;
            label1.Text = "Sudah punya akun?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonHighlight;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnLogin.ForeColor = Color.Purple;
            btnLogin.Location = new Point(1174, 914);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login di sini";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.BackColor = SystemColors.ButtonHighlight;
            chkShow.Location = new Point(864, 792);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(82, 29);
            chkShow.TabIndex = 7;
            chkShow.Text = "Show";
            chkShow.UseVisualStyleBackColor = false;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // Daftar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1511, 982);
            Controls.Add(chkShow);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(btnDaftar);
            Controls.Add(tbKataSandi);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Name = "Daftar";
            Text = "Daftar";
            Load += Daftar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private TextBox tbEmail;
        private TextBox tbKataSandi;
        private Button btnDaftar;
        private Label label1;
        private Button btnLogin;
        private CheckBox chkShow;
    }
}