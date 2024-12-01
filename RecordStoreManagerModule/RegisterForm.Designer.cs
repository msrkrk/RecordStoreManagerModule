namespace RecordStoreManagerModule
{
    partial class RegisterForm
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
            txtUserName = new TextBox();
            txtRepeatPassword = new TextBox();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            chkShowRepeatPassword = new CheckBox();
            lblUserName = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(152, 43);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(276, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(151, 143);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(277, 23);
            txtRepeatPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 94);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(277, 23);
            txtPassword.TabIndex = 2;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(434, 99);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(60, 19);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Göster";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // chkShowRepeatPassword
            // 
            chkShowRepeatPassword.AutoSize = true;
            chkShowRepeatPassword.Location = new Point(434, 147);
            chkShowRepeatPassword.Name = "chkShowRepeatPassword";
            chkShowRepeatPassword.Size = new Size(60, 19);
            chkShowRepeatPassword.TabIndex = 4;
            chkShowRepeatPassword.Text = "Göster";
            chkShowRepeatPassword.UseVisualStyleBackColor = true;
            chkShowRepeatPassword.CheckedChanged += chkShowRepeatPassword_CheckedChanged;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(70, 46);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(76, 15);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 99);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 146);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Şifre Tekrarı:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(151, 190);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "KAYIT OL";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(353, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 247);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUserName);
            Controls.Add(chkShowRepeatPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtRepeatPassword);
            Controls.Add(txtUserName);
            MaximumSize = new Size(562, 286);
            MinimumSize = new Size(562, 286);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtRepeatPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private CheckBox chkShowRepeatPassword;
        private Label lblUserName;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private Button btnCancel;
    }
}