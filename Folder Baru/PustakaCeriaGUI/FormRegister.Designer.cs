namespace PustakaCeriaGUI
{
    partial class FormRegister
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
            buttonMasuk = new Button();
            label4 = new Label();
            buttonDaftar = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonMasuk
            // 
            buttonMasuk.BackColor = SystemColors.HighlightText;
            buttonMasuk.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMasuk.ForeColor = Color.Blue;
            buttonMasuk.Location = new Point(47, 396);
            buttonMasuk.Name = "buttonMasuk";
            buttonMasuk.Size = new Size(301, 42);
            buttonMasuk.TabIndex = 15;
            buttonMasuk.Text = "Masuk";
            buttonMasuk.UseVisualStyleBackColor = false;
            buttonMasuk.Click += buttonMasuk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(181, 373);
            label4.Name = "label4";
            label4.Size = new Size(33, 16);
            label4.TabIndex = 14;
            label4.Text = "Atau";
            // 
            // buttonDaftar
            // 
            buttonDaftar.BackColor = Color.Blue;
            buttonDaftar.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDaftar.ForeColor = SystemColors.HighlightText;
            buttonDaftar.Location = new Point(47, 324);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(301, 42);
            buttonDaftar.TabIndex = 13;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = false;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(47, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(47, 197);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 27);
            txtUsername.TabIndex = 11;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(47, 134);
            label3.Name = "label3";
            label3.Size = new Size(227, 18);
            label3.TabIndex = 10;
            label3.Text = "Daftar akun kamu di Pustaka Ceria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(47, 91);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 9;
            label2.Text = "Pustaka Ceria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 60);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 8;
            label1.Text = "Daftar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(47, 176);
            label5.Name = "label5";
            label5.Size = new Size(113, 18);
            label5.TabIndex = 16;
            label5.Text = "Nama pengguna";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Pro Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(47, 238);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 17;
            label6.Text = "Kata sandi";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(395, 487);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonMasuk);
            Controls.Add(label4);
            Controls.Add(buttonDaftar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMasuk;
        private Label label4;
        private Button buttonDaftar;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
    }
}