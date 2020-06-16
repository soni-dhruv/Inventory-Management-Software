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

        // To Login Page
        private void btn2Login_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        // X Close Button
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
            if(Regex.IsMatch(txtboxEMail.Text, emailPattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.eMail, "Enter Valid E-Mail");
                return;
            }
        }

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
            }
        }

        // Password TextBox Policy
        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
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
                foreach(char ch in pass)
                {
                    if(ch.Equals('!') || ch.Equals('@') || ch.Equals('#') || ch.Equals('$') || ch.Equals('%') || ch.Equals('+')
                    || ch.Equals('^') || ch.Equals('&') || ch.Equals('*') || ch.Equals('(') || ch.Equals(')') || ch.Equals('-')
                    || ch.Equals('_') || ch.Equals('=') || ch.Equals('.'))
                    {
                        num++;
                    }
                }
                return num;
            }

            if (txtBoxPassword.Text.Length > 7 && numberPass(txtBoxPassword.Text) >= 1 && upperCase(txtBoxPassword.Text) >= 1 
                && lowerCase(txtBoxPassword.Text) >= 1 && specialChar(txtBoxPassword.Text) >= 1)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(password, "Uppercase, Lowercase, Numeric and Special Character Combination Required");
            }
        }   
    }
}