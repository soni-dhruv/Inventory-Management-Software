namespace IMS
{
    partial class SignupForm
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
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.lblSignUpForm = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.mobileNo = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btn2Login = new System.Windows.Forms.Button();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.txtBoxMobileNo = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.LLPasswordShow = new System.Windows.Forms.LinkLabel();
            this.txtboxLName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtboxEMail = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llCnfShow = new System.Windows.Forms.LinkLabel();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.Blue;
            this.SignUpPanel.Controls.Add(this.Close);
            this.SignUpPanel.Controls.Add(this.lblSignUpForm);
            this.SignUpPanel.Location = new System.Drawing.Point(-1, 0);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(368, 50);
            this.SignUpPanel.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Blue;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(333, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 30);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblSignUpForm
            // 
            this.lblSignUpForm.AutoSize = true;
            this.lblSignUpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpForm.ForeColor = System.Drawing.Color.White;
            this.lblSignUpForm.Location = new System.Drawing.Point(61, 9);
            this.lblSignUpForm.Name = "lblSignUpForm";
            this.lblSignUpForm.Size = new System.Drawing.Size(237, 31);
            this.lblSignUpForm.TabIndex = 1;
            this.lblSignUpForm.Text = "New User Sign Up";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fName.Location = new System.Drawing.Point(11, 65);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(81, 18);
            this.fName.TabIndex = 1;
            this.fName.Text = "First Name";
            // 
            // mobileNo
            // 
            this.mobileNo.AutoSize = true;
            this.mobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mobileNo.Location = new System.Drawing.Point(11, 120);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(109, 18);
            this.mobileNo.TabIndex = 2;
            this.mobileNo.Text = "Mobile Number";
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.userId.Location = new System.Drawing.Point(11, 175);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(58, 18);
            this.userId.TabIndex = 3;
            this.userId.Text = "User ID";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.password.Location = new System.Drawing.Point(11, 230);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 18);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.confirmPassword.Location = new System.Drawing.Point(11, 285);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(132, 18);
            this.confirmPassword.TabIndex = 5;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Green;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(50, 343);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(262, 30);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // btn2Login
            // 
            this.btn2Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2Login.FlatAppearance.BorderSize = 0;
            this.btn2Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Login.ForeColor = System.Drawing.Color.White;
            this.btn2Login.Location = new System.Drawing.Point(50, 385);
            this.btn2Login.Name = "btn2Login";
            this.btn2Login.Size = new System.Drawing.Size(262, 30);
            this.btn2Login.TabIndex = 13;
            this.btn2Login.Text = "Already User? Login here";
            this.btn2Login.UseVisualStyleBackColor = false;
            this.btn2Login.Click += new System.EventHandler(this.btn2Login_Click);
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFName.Location = new System.Drawing.Point(14, 86);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(163, 22);
            this.txtBoxFName.TabIndex = 6;
            this.txtBoxFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFName_KeyPress);
            // 
            // txtBoxMobileNo
            // 
            this.txtBoxMobileNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMobileNo.Location = new System.Drawing.Point(14, 141);
            this.txtBoxMobileNo.Name = "txtBoxMobileNo";
            this.txtBoxMobileNo.Size = new System.Drawing.Size(163, 22);
            this.txtBoxMobileNo.TabIndex = 7;
            this.txtBoxMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMobileNo_KeyPress);
            // 
            // txtUid
            // 
            this.txtUid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUid.Location = new System.Drawing.Point(14, 196);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(335, 22);
            this.txtUid.TabIndex = 8;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(14, 251);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.Size = new System.Drawing.Size(335, 22);
            this.txtBoxPassword.TabIndex = 9;
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(14, 306);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.PasswordChar = '●';
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(335, 22);
            this.txtBoxConfirmPassword.TabIndex = 11;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // LLPasswordShow
            // 
            this.LLPasswordShow.AutoSize = true;
            this.LLPasswordShow.BackColor = System.Drawing.Color.White;
            this.LLPasswordShow.Location = new System.Drawing.Point(310, 256);
            this.LLPasswordShow.Name = "LLPasswordShow";
            this.LLPasswordShow.Size = new System.Drawing.Size(34, 13);
            this.LLPasswordShow.TabIndex = 10;
            this.LLPasswordShow.TabStop = true;
            this.LLPasswordShow.Text = "Show";
            this.LLPasswordShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLPasswordShow_LinkClicked);
            // 
            // txtboxLName
            // 
            this.txtboxLName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLName.Location = new System.Drawing.Point(189, 86);
            this.txtboxLName.Name = "txtboxLName";
            this.txtboxLName.Size = new System.Drawing.Size(163, 22);
            this.txtboxLName.TabIndex = 7;
            this.txtboxLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFName_KeyPress);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lName.Location = new System.Drawing.Point(186, 65);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(80, 18);
            this.lName.TabIndex = 14;
            this.lName.Text = "Last Name";
            // 
            // txtboxEMail
            // 
            this.txtboxEMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEMail.Location = new System.Drawing.Point(189, 141);
            this.txtboxEMail.Name = "txtboxEMail";
            this.txtboxEMail.Size = new System.Drawing.Size(163, 22);
            this.txtboxEMail.TabIndex = 8;
            this.txtboxEMail.Leave += new System.EventHandler(this.tetboxEMail_Leave);
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.eMail.Location = new System.Drawing.Point(186, 120);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(68, 18);
            this.eMail.TabIndex = 15;
            this.eMail.Text = "E-Mail ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // llCnfShow
            // 
            this.llCnfShow.AutoSize = true;
            this.llCnfShow.BackColor = System.Drawing.Color.White;
            this.llCnfShow.Location = new System.Drawing.Point(310, 311);
            this.llCnfShow.Name = "llCnfShow";
            this.llCnfShow.Size = new System.Drawing.Size(34, 13);
            this.llCnfShow.TabIndex = 12;
            this.llCnfShow.TabStop = true;
            this.llCnfShow.Text = "Show";
            this.llCnfShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCnfShow_LinkClicked);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 436);
            this.Controls.Add(this.llCnfShow);
            this.Controls.Add(this.txtboxEMail);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.txtboxLName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.LLPasswordShow);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.txtBoxMobileNo);
            this.Controls.Add(this.txtBoxFName);
            this.Controls.Add(this.btn2Login);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.mobileNo);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.SignUpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Label lblSignUpForm;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label mobileNo;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btn2Login;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.TextBox txtBoxMobileNo;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.LinkLabel LLPasswordShow;
        private System.Windows.Forms.TextBox txtboxLName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtboxEMail;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.LinkLabel llCnfShow;
    }
}