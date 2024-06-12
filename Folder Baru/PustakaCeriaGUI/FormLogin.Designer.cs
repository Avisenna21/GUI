namespace PustakaCeriaGUI
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            buttonMasuk = new Button();
            label4 = new Label();
            buttonDaftar = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 63);
            label1.Name = "label1";
            label1.Size = new Size(177, 24);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang di";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(48, 94);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 1;
            label2.Text = "Pustaka Ceria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(48, 137);
            label3.Name = "label3";
            label3.Size = new Size(237, 18);
            label3.TabIndex = 2;
            label3.Text = "Login untuk masuk ke Pustaka Ceria";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(48, 211);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(48, 274);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 27);
            txtPassword.TabIndex = 4;
            // 
            // buttonMasuk
            // 
            buttonMasuk.BackColor = Color.Blue;
            buttonMasuk.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMasuk.ForeColor = SystemColors.HighlightText;
            buttonMasuk.Location = new Point(48, 333);
            buttonMasuk.Name = "buttonMasuk";
            buttonMasuk.Size = new Size(301, 42);
            buttonMasuk.TabIndex = 5;
            buttonMasuk.Text = "Masuk";
            buttonMasuk.UseVisualStyleBackColor = false;
            buttonMasuk.Click += buttonMasuk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(182, 382);
            label4.Name = "label4";
            label4.Size = new Size(33, 16);
            label4.TabIndex = 6;
            label4.Text = "Atau";
            // 
            // buttonDaftar
            // 
            buttonDaftar.BackColor = SystemColors.HighlightText;
            buttonDaftar.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDaftar.ForeColor = Color.Blue;
            buttonDaftar.Location = new Point(48, 405);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(301, 42);
            buttonDaftar.TabIndex = 7;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = false;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(48, 187);
            label5.Name = "label5";
            label5.Size = new Size(113, 18);
            label5.TabIndex = 8;
            label5.Text = "Nama pengguna";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(48, 252);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 9;
            label6.Text = "Kata sandi";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(389, 485);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonDaftar);
            Controls.Add(label4);
            Controls.Add(buttonMasuk);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button buttonMasuk;
        private Label label4;
        private Button buttonDaftar;
        private Label label5;
        private Label label6;
    }
}
