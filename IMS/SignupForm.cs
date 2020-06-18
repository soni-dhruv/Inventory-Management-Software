using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace IMS
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            this.ActiveControl = txtBoxFName;
        }

<<<<<<< HEAD
=======
        // To Login Page
        private void btn2Login_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
        // X Close Button
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

<<<<<<< HEAD
        // Only Letters validation 
        private void txtBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
=======
        // Show Hide Link Label
        private void LLPasswordShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LLPasswordShow.Text == "Show")
            {
                txtBoxPassword.PasswordChar = '\0';
                LLPasswordShow.Text = "Hide";
            }
            else
            {
                txtBoxPassword.PasswordChar = '●';
                LLPasswordShow.Text = "Show";
            }
        }

        // Only Letters validation 
        private void txtBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
            {
                e.Handled = true;
            }
        }

        // Mobile Numbers only validation 
        private void txtBoxMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            txtBoxMobileNo.MaxLength = 10;
        }

        // Mobile Numbers length validation
        private void txtBoxMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtBoxMobileNo.TextLength < 10)
            {
                errorProvider2.SetError(mobileNo, "Mobile Number Should be 10 Digits");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        // E-Mail Text Box
        private void tetboxEMail_Leave(object sender, EventArgs e)
        {
            string emailPattern = "^([0-9a-zA-z]([-\\.\\w]*[0-9a-zA-z]*@[0-9a-zA-z][-\\w]*[0-9a-zA-z]\\.)+[a-zA-z]{2,9})$";
<<<<<<< HEAD
            if (Regex.IsMatch(txtboxEMail.Text, emailPattern))
=======
            if(Regex.IsMatch(txtboxEMail.Text, emailPattern))
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
            {
                errorProvider1.Clear();
            }
            else
            {
<<<<<<< HEAD
                errorProvider1.SetError(eMail, "Enter Valid E-Mail");
=======
                errorProvider1.SetError(this.eMail, "Enter Valid E-Mail");
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
                return;
            }
        }

<<<<<<< HEAD
        // Show Hide Link Label
        private void LLPasswordShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LLPasswordShow.Text == "Show")
            {
                txtBoxPassword.PasswordChar = '\0';
                LLPasswordShow.Text = "Hide";
            }
            else
            {
                txtBoxPassword.PasswordChar = '●';
                LLPasswordShow.Text = "Show";
=======
        // Confirm Text Box
        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBoxConfirmPassword.Text == "")
            {
                errorProvider2.SetError(confirmPassword, "Enter Confirm Password");
            }
            else if (txtBoxPassword.Text != "" && txtBoxConfirmPassword.Text == txtBoxPassword.Text)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(confirmPassword, "Password and Confirm Password Don't Match.");
                
            }
        }

        // Confirm Text Box Show & Hide
        private void llCnfShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llCnfShow.Text == "Show")
            {
                txtBoxConfirmPassword.PasswordChar = '\0';
                llCnfShow.Text = "Hide";
            }
            else
            {
                txtBoxConfirmPassword.PasswordChar = '●';
                llCnfShow.Text = "Show";
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
            }
        }

        // Password TextBox Policy
        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
            string userName = txtBoxPassword.Text;
            int numberPass(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (char.IsDigit(ch))
                    {
                        num++;
                    }
                }
                return num;
            }

            int upperCase(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (char.IsUpper(ch))
                    {
                        num++;
                    }
                }
                return num;
            }

            int lowerCase(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (char.IsLower(ch))
                    {
                        num++;
                    }
                }
                return num;
            }

            int specialChar(string pass)
            {
                int num = 0;
<<<<<<< HEAD
                foreach (char ch in pass)
                {
                    if (ch.Equals('!') || ch.Equals('@') || ch.Equals('#') || ch.Equals('$') || ch.Equals('%') || ch.Equals('+')
=======
                foreach(char ch in pass)
                {
                    if(ch.Equals('!') || ch.Equals('@') || ch.Equals('#') || ch.Equals('$') || ch.Equals('%') || ch.Equals('+')
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
                    || ch.Equals('^') || ch.Equals('&') || ch.Equals('*') || ch.Equals('(') || ch.Equals(')') || ch.Equals('-')
                    || ch.Equals('_') || ch.Equals('=') || ch.Equals('.'))
                    {
                        num++;
                    }
                }
                return num;
            }

<<<<<<< HEAD
            if (txtBoxPassword.Text.Length > 7 && numberPass(txtBoxPassword.Text) >= 1 && upperCase(txtBoxPassword.Text) >= 1
=======
            if (txtBoxPassword.Text.Length > 7 && numberPass(txtBoxPassword.Text) >= 1 && upperCase(txtBoxPassword.Text) >= 1 
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
                && lowerCase(txtBoxPassword.Text) >= 1 && specialChar(txtBoxPassword.Text) >= 1)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(password, "Uppercase, Lowercase, Numeric and Special Character Combination Required");
            }
<<<<<<< HEAD
        }

        // Confirm Password Text Box
        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxConfirmPassword.Text == "")
            {
                errorProvider2.SetError(confirmPassword, "Enter Confirm Password");
            }
            else if (txtBoxPassword.Text != "" && txtBoxConfirmPassword.Text == txtBoxPassword.Text)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(confirmPassword, "Password and Confirm Password Don't Match.");

            }
        }

        // Confirm Text Box Show & Hide
        private void llCnfShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llCnfShow.Text == "Show")
            {
                txtBoxConfirmPassword.PasswordChar = '\0';
                llCnfShow.Text = "Hide";
            }
            else
            {
                txtBoxConfirmPassword.PasswordChar = '●';
                llCnfShow.Text = "Show";
            }
        }

        // Back To Login Page
        private void btn2Login_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        //Sign up Button
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // First Name Blank Validation
            if (txtBoxFName.Text == "")
            {
                errorProvider4.SetError(fName, "*Required Field");
            }
            else
            {
                errorProvider4.Clear();
            }

            // Last Name Blank Validation
            if (txtBoxLName.Text == "")
            {
                errorProvider5.SetError(lName, "*Required Field");
            }
            else
            {
                errorProvider5.Clear();
            }

            // Mobile Number Blank Validation
            if (txtBoxMobileNo.Text == "")
            {
                errorProvider6.SetError(mobileNo, "*Required Field");
            }
            else
            {
                errorProvider6.Clear();
            }

            // E-Mail Blank Validation
            if (txtboxEMail.Text == "")
            {
                errorProvider7.SetError(eMail, "*Required Field");
            }
            else
            {
                errorProvider7.Clear();
            }

            // User ID Blank Validation
            if (txtBoxUid.Text == "")
            {
                errorProvider8.SetError(userId, "*Required Field");
            }
            else
            {
                errorProvider8.Clear();
            }

            // Password Blank Validation
            if (txtBoxPassword.Text == "")
            {
                errorProvider9.SetError(password, "*Required Field");
            }
            else
            {
                errorProvider9.Clear();
            }

            // Confirm Password Blank Validation
            if (txtBoxConfirmPassword.Text == "")
            {
                errorProvider10.SetError(confirmPassword, "*Required Field");
            }
            else
            {
                errorProvider10.Clear();
            }
        }
=======
        }   
>>>>>>> f38e2f5a7924142f1345d5d755958744ee721974
    }
}