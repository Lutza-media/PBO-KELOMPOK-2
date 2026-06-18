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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            btnEmailEdit = new TextBox();
            btnNamaLengkap = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1512, 982);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(491, 44);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 31;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEmailEdit
            // 
            btnEmailEdit.BackColor = Color.White;
            btnEmailEdit.BorderStyle = BorderStyle.FixedSingle;
            btnEmailEdit.Location = new Point(659, 582);
            btnEmailEdit.Name = "btnEmailEdit";
            btnEmailEdit.Size = new Size(273, 31);
            btnEmailEdit.TabIndex = 32;
            btnEmailEdit.UseWaitCursor = true;
            // 
            // btnNamaLengkap
            // 
            btnNamaLengkap.BackColor = Color.White;
            btnNamaLengkap.BorderStyle = BorderStyle.FixedSingle;
            btnNamaLengkap.Location = new Point(659, 475);
            btnNamaLengkap.Name = "btnNamaLengkap";
            btnNamaLengkap.Size = new Size(273, 31);
            btnNamaLengkap.TabIndex = 33;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(46, 359);
            button2.Name = "button2";
            button2.Size = new Size(319, 59);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGoldenrod;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(46, 453);
            button3.Name = "button3";
            button3.Size = new Size(319, 59);
            button3.TabIndex = 35;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGoldenrod;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(46, 545);
            button4.Name = "button4";
            button4.Size = new Size(319, 59);
            button4.TabIndex = 36;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Location = new Point(46, 635);
            button5.Name = "button5";
            button5.Size = new Size(319, 59);
            button5.TabIndex = 37;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(560, 850);
            button6.Name = "button6";
            button6.Size = new Size(200, 44);
            button6.TabIndex = 38;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(838, 850);
            button7.Name = "button7";
            button7.Size = new Size(200, 44);
            button7.TabIndex = 39;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // EditProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 978);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnNamaLengkap);
            Controls.Add(btnEmailEdit);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "EditProfil";
            Text = "EditProfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox btnEmailEdit;
        private TextBox btnNamaLengkap;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}