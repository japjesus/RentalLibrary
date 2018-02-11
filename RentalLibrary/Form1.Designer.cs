namespace RentalLibrary
{
    partial class RegisterUser
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.UsernameLogin = new System.Windows.Forms.Label();
            this.PasswordLogin = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TextBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPasswordLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Location = new System.Drawing.Point(117, 160);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(75, 23);
            this.ButtonRegister.TabIndex = 0;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(40, 63);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(55, 13);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(42, 113);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(106, 60);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUsername.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(106, 109);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.AutoSize = true;
            this.UsernameLogin.Location = new System.Drawing.Point(324, 63);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new System.Drawing.Size(55, 13);
            this.UsernameLogin.TabIndex = 5;
            this.UsernameLogin.Text = "Username";
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.AutoSize = true;
            this.PasswordLogin.Location = new System.Drawing.Point(324, 109);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.PasswordLogin.TabIndex = 6;
            this.PasswordLogin.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(421, 160);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TextBoxUsernameLogin
            // 
            this.TextBoxUsernameLogin.Location = new System.Drawing.Point(410, 60);
            this.TextBoxUsernameLogin.Name = "TextBoxUsernameLogin";
            this.TextBoxUsernameLogin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUsernameLogin.TabIndex = 8;
            // 
            // TextBoxPasswordLogin
            // 
            this.TextBoxPasswordLogin.Location = new System.Drawing.Point(410, 109);
            this.TextBoxPasswordLogin.Name = "TextBoxPasswordLogin";
            this.TextBoxPasswordLogin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPasswordLogin.TabIndex = 9;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 254);
            this.Controls.Add(this.TextBoxPasswordLogin);
            this.Controls.Add(this.TextBoxUsernameLogin);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UsernameLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonRegister);
            this.Name = "RegisterUser";
            this.Text = "Register User";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label UsernameLogin;
        private System.Windows.Forms.Label PasswordLogin;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox TextBoxUsernameLogin;
        private System.Windows.Forms.TextBox TextBoxPasswordLogin;
    }
}

