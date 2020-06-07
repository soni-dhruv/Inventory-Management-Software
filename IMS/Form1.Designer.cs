namespace IMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.txtBoxUname = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.uPassword = new System.Windows.Forms.Label();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.LLForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.LLPasswordShow = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPicture
            // 
            this.LoginPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoginPicture.Image")));
            this.LoginPicture.Location = new System.Drawing.Point(122, 18);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(125, 124);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginPicture.TabIndex = 1;
            this.LoginPicture.TabStop = false;
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.AutoSize = true;
            this.UserLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UserLoginLabel.Location = new System.Drawing.Point(117, 145);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(130, 29);
            this.UserLoginLabel.TabIndex = 2;
            this.UserLoginLabel.Text = "User Login";
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.Location = new System.Drawing.Point(47, 191);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(100, 22);
            this.uName.TabIndex = 4;
            this.uName.Text = "User Name";
            // 
            // txtBoxUname
            // 
            this.txtBoxUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUname.Location = new System.Drawing.Point(51, 216);
            this.txtBoxUname.Name = "txtBoxUname";
            this.txtBoxUname.Size = new System.Drawing.Size(262, 23);
            this.txtBoxUname.TabIndex = 5;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(51, 273);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.Size = new System.Drawing.Size(262, 23);
            this.txtBoxPassword.TabIndex = 7;
            // 
            // uPassword
            // 
            this.uPassword.AutoSize = true;
            this.uPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPassword.Location = new System.Drawing.Point(47, 248);
            this.uPassword.Name = "uPassword";
            this.uPassword.Size = new System.Drawing.Size(89, 22);
            this.uPassword.TabIndex = 6;
            this.uPassword.Text = "Password";
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMe.Location = new System.Drawing.Point(51, 309);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(119, 21);
            this.RememberMe.TabIndex = 8;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // LLForgotPassword
            // 
            this.LLForgotPassword.AutoSize = true;
            this.LLForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLForgotPassword.Location = new System.Drawing.Point(191, 309);
            this.LLForgotPassword.Name = "LLForgotPassword";
            this.LLForgotPassword.Size = new System.Drawing.Size(122, 17);
            this.LLForgotPassword.TabIndex = 9;
            this.LLForgotPassword.TabStop = true;
            this.LLForgotPassword.Text = "Forgot Password?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(51, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(262, 30);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(51, 382);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(262, 30);
            this.btnSignup.TabIndex = 11;
            this.btnSignup.Text = "New User? Signup here";
            this.btnSignup.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.White;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Close.Location = new System.Drawing.Point(324, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 30);
            this.Close.TabIndex = 12;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LLPasswordShow
            // 
            this.LLPasswordShow.AutoSize = true;
            this.LLPasswordShow.BackColor = System.Drawing.Color.White;
            this.LLPasswordShow.Location = new System.Drawing.Point(270, 278);
            this.LLPasswordShow.Name = "LLPasswordShow";
            this.LLPasswordShow.Size = new System.Drawing.Size(34, 13);
            this.LLPasswordShow.TabIndex = 13;
            this.LLPasswordShow.TabStop = true;
            this.LLPasswordShow.Text = "Show";
            this.LLPasswordShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLPasswordShow_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 436);
            this.Controls.Add(this.LLPasswordShow);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LLForgotPassword);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.uPassword);
            this.Controls.Add(this.txtBoxUname);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.UserLoginLabel);
            this.Controls.Add(this.LoginPicture);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.Label UserLoginLabel;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.TextBox txtBoxUname;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label uPassword;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.LinkLabel LLForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.LinkLabel LLPasswordShow;
    }
}

