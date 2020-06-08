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

namespace IMS
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            this.ActiveControl = txtBoxFName;
        }

        // X Close Button
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // To Login Page
        private void btn2Login_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
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

        // Only Numbers validation 
        private void txtBoxMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBoxConfirmPassword.Text == "")
            {
                errorProvider2.SetError(confirmPassword, "Enter Confirm Password");
            }
            else if (txtBoxPassword.Text != "" && txtBoxConfirmPassword.Text == txtBoxPassword.Text)
            {
                errorProvider2.SetError(confirmPassword, "");
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
    }
}