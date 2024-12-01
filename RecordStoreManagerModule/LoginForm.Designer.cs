namespace RecordStoreManagerModule
{
    partial class LoginForm
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
            txtUserName = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            chkShowPassword = new CheckBox();
            label2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(106, 30);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(142, 23);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "Test";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(116, 122);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(121, 162);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(62, 15);
            lnkRegister.TabIndex = 3;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "KAYIT OL !";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(267, 78);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(60, 19);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Göster";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(142, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "ASDasd123+*";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(lnkRegister);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private CheckBox chkShowPassword;
        private Label label2;
        private TextBox txtPassword;
    }
}
